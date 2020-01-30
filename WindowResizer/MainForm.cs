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
                label1,
                label2,
                origWidth,
                origHeight,
                widthNud,
                heightNud,
                resizeButton
            };
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            windowInfoControls.ForEach(c => c.Hide());
            treeView.Nodes.Clear();
            var procNodes = new Dictionary<int, TreeNode>();
            foreach (var proc in Process.GetProcesses()) {
                procNodes[proc.Id] = new TreeNode($"0x{proc.Id:X8} {proc.ProcessName}") { Tag = proc };
            }
            User32Dll.EnumWindows((hWnd, lParam) => {
                try {
                    User32Dll.GetWindowThreadProcessId(hWnd, out var id);
                    if (procNodes.TryGetValue((int)id, out var node)) {
                        var capacity = User32Dll.GetWindowTextLength(new HandleRef(this, hWnd)) * 2;
                        var sb = new StringBuilder(capacity);
                        if (capacity > 0) {
                            User32Dll.GetWindowText(new HandleRef(this, hWnd), sb, capacity);
                        }
                        TreeNode wndNode;
                        if (capacity > 0 && User32Dll.GetWindowRect(new HandleRef(this, hWnd), out var rct) && !rct.IsEmpty) {
                            wndNode = new TreeNode($"0x{(int)hWnd:X8} {sb.ToString()}", 2, 2) { Tag = hWnd };
                            node.Nodes.Add(wndNode);
                        } else if (showAll.Checked) {
                            wndNode = new TreeNode($"0x{(int)hWnd:X8} {sb.ToString()}", 1, 1) { Tag = null };
                            wndNode.ForeColor = Color.Gray;
                            node.Nodes.Add(wndNode);
                        }
                    }
                } catch {
                    // ignore
                }
                return true;
            }, IntPtr.Zero);
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
            if (e.Node.ImageIndex == 2 && e.Node.Tag != null) {
                var hWnd = (IntPtr)e.Node.Tag;
                if (User32Dll.GetWindowRect(new HandleRef(this, hWnd), out var rct) && !rct.IsEmpty) {
                    var w = rct.Width;
                    origWidth.Text = $"{w}px";
                    widthNud.Value = w;
                    var h = rct.Height;
                    origHeight.Text = $"{h}px";
                    heightNud.Value = h;
                    windowInfoControls.ForEach(c => c.Show());
                }
            }
        }

        private void resizeButton_Click(object sender, EventArgs e) {
            var selected = treeView.SelectedNode;
            if (selected != null && selected.ImageIndex == 2 && selected.Tag != null) {
                var hWnd = (IntPtr)selected.Tag;
                if (User32Dll.GetWindowRect(new HandleRef(this, hWnd), out var rct)) {
                    User32Dll.MoveWindow(hWnd, rct.Left, rct.Top, (int)widthNud.Value, (int)heightNud.Value, true);
                    User32Dll.GetWindowRect(new HandleRef(this, hWnd), out var rct2);
                    var w = rct2.Right - rct2.Left;
                    origWidth.Text = $"{w}px";
                    widthNud.Value = w;
                    var h = rct2.Bottom - rct2.Top;
                    origHeight.Text = $"{h}px";
                    heightNud.Value = h;
                } else {
                    MessageBox.Show("Error has appeared.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showAll_CheckedChanged(object sender, EventArgs e) => refreshButton_Click(sender, e);
    }
}
