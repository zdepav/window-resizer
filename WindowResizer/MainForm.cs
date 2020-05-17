using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowResizer.Properties;

namespace WindowResizer {

    public partial class MainForm : Form {

        private readonly List<Control> windowInfoControls;

        private Image capturedImage;

        public MainForm() {
            InitializeComponent();
            var imgList = new ImageList();
            imgList.Images.Add(Resources.icon_none);
            imgList.Images.Add(Resources.icon_hidden_window);
            imgList.Images.Add(Resources.icon_window);
            imgList.Images.Add(Resources.icon_background_process);
            imgList.Images.Add(Resources.icon_process);
            treeView.ImageList = imgList;
            windowInfoControls = new List<Control> {
                label1, label2, label3, label4,
                origX, origY, origWidth, origHeight,
                xNud, yNud, widthNud, heightNud,
                resizeButton, pictureBox
            };
            capturedImage = null;
            pictureBox.AutoSize = true;
        }

        public bool CaptureWindow(IntPtr handle, out Image image) {
            var hdcSrc = User32Dll.GetWindowDC(handle);
            User32Dll.GetWindowRect(handle, out var windowRect);
            var hdcDest = new HandleRef(this, Gdi32Dll.CreateCompatibleDC(hdcSrc));
            var hBitmap = new HandleRef(
                this,
                Gdi32Dll.CreateCompatibleBitmap(
                    hdcSrc,
                    windowRect.Width,
                    windowRect.Height
                )
            );
            var hOld = new HandleRef(this, Gdi32Dll.SelectObject(hdcDest, hBitmap));
            var success = Gdi32Dll.BitBlt(
                hdcDest,
                0, 0,
                windowRect.Width,
                windowRect.Height,
                hdcSrc,
                0, 0,
                (int)Gdi32Dll.TernaryRasterOperations.SRCCOPY
            );
            Gdi32Dll.SelectObject(hdcDest, hOld);
            Gdi32Dll.DeleteDC(hdcDest);
            User32Dll.ReleaseDC(handle, hdcSrc);
            image = success ? Image.FromHbitmap(hBitmap.Handle) : null;
            Gdi32Dll.DeleteObject(hBitmap);
            return success;
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            windowInfoControls.ForEach(c => c.Hide());
            treeView.Nodes.Clear();
            pictureBox.Image = null;
            capturedImage?.Dispose();
            var procNodes = new Dictionary<int, TreeNode>();
            foreach (var proc in Process.GetProcesses()) {
                procNodes[proc.Id] = new TreeNode($"0x{proc.Id:X8} {proc.ProcessName}") {
                    Tag = proc
                };
            }
            User32Dll.EnumWindows(
                (hWnd, lParam) => {
                    try {
                        User32Dll.GetWindowThreadProcessId(hWnd, out var id);
                        if (procNodes.TryGetValue((int)id, out var node)) {
                            var capacity = User32Dll.GetWindowTextLength(hWnd) * 2;
                            var sb = new StringBuilder(capacity);
                            if (capacity > 0) {
                                User32Dll.GetWindowText(hWnd, sb, capacity);
                            }
                            TreeNode wndNode;
                            if (capacity > 0 &&
                                User32Dll.GetWindowRect(hWnd, out var rct) &&
                                !rct.IsEmpty
                            ) {
                                wndNode = new TreeNode(
                                    $"0x{(int)hWnd:X8} {sb}", 2, 2
                                ) {
                                    Tag = hWnd
                                };
                                node.Nodes.Add(wndNode);
                            } else if (showAll.Checked) {
                                wndNode = new TreeNode(
                                    $"0x{(int)hWnd:X8} {sb}", 1, 1
                                ) {
                                    Tag = null,
                                    ForeColor = Color.Gray
                                };
                                node.Nodes.Add(wndNode);
                            }
                        }
                    } catch {
                        // ignore
                    }
                    return true;
                }, IntPtr.Zero
            );
            foreach (var kvp in procNodes.OrderBy(kvp => ((Process)kvp.Value.Tag).ProcessName)) {
                if (kvp.Value.Nodes.Count > 0) {
                    kvp.Value.ImageIndex = kvp.Value.SelectedImageIndex = 4;
                    treeView.Nodes.Add(kvp.Value);
                } else if (showAll.Checked) {
                    kvp.Value.ImageIndex = kvp.Value.SelectedImageIndex = 3;
                    kvp.Value.ForeColor = Color.Gray;
                    treeView.Nodes.Add(kvp.Value);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) => refreshButton_Click(sender, e);

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            windowInfoControls.ForEach(c => c.Hide());
            pictureBox.Image = null;
            capturedImage?.Dispose();
            if (e.Node.ImageIndex == 2 &&
                e.Node.Tag != null
            ) {
                var hWnd = (IntPtr)e.Node.Tag;
                if (User32Dll.GetWindowRect(hWnd, out var rct) && !rct.IsEmpty) {
                    DisplayRect(rct);
                    if (CaptureWindow(hWnd, out capturedImage)) {
                        pictureBox.Image = capturedImage;
                    }
                    windowInfoControls.ForEach(c => c.Show());
                }
            }
        }

        private void DisplayRect(User32Dll.RECT rect) {
            origX.Text = $"{rect.Left}px";
            xNud.Value = rect.Left;
            origY.Text = $"{rect.Top}px";
            yNud.Value = rect.Top;
            origWidth.Text = $"{rect.Width}px";
            widthNud.Value = rect.Width;
            origHeight.Text = $"{rect.Height}px";
            heightNud.Value = rect.Height;
        }

        private void resizeButton_Click(object sender, EventArgs e) {
            var selected = treeView.SelectedNode;
            if (selected != null &&
                selected.ImageIndex == 2 &&
                selected.Tag != null
            ) {
                var hWnd = (IntPtr)selected.Tag;
                if (User32Dll.GetWindowRect(hWnd, out _)) {
                    User32Dll.MoveWindow(
                        hWnd,
                        (int)xNud.Value,
                        (int)yNud.Value,
                        (int)widthNud.Value,
                        (int)heightNud.Value,
                        true
                    );
                    User32Dll.GetWindowRect(hWnd, out var rct2);
                    DisplayRect(rct2);
                } else {
                    MessageBox.Show(
                        "Error has appeared.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void showAll_CheckedChanged(object sender, EventArgs e) =>
            refreshButton_Click(sender, e);
    }
}
