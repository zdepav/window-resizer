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

    public partial class Form1 : Form {

        #region Dll imports

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowTextLength(HandleRef hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(HandleRef hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;   // x position of upper-left corner
            public int Top;    // y position of upper-left corner
            public int Right;  // x position of lower-right corner
            public int Bottom; // y position of lower-right corner
        }

        private bool NotEmpty(RECT rct) => rct.Right > 0 || rct.Left > 0 || rct.Top > 0 || rct.Bottom > 0;

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        #endregion

        private readonly List<Control> windowInfoControls;

        public Form1() {
            InitializeComponent();
            var imgList = new ImageList();
            imgList.Images.Add(Resources.icon_none);
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
            foreach (var proc in Process.GetProcesses())
                procNodes[proc.Id] = new TreeNode($"0x{proc.Id:X8} {proc.ProcessName}") { Tag = proc };
            EnumWindows((hWnd, lParam) => {
                try {
                    GetWindowThreadProcessId(hWnd, out var id);
                    if (procNodes.TryGetValue((int)id, out var node)) {
                        var capacity = GetWindowTextLength(new HandleRef(this, hWnd)) * 2;
                        var sb = new StringBuilder(capacity);
                        GetWindowText(new HandleRef(this, hWnd), sb, sb.Capacity);
                        node.Nodes.Add(new TreeNode($"0x{(int)hWnd:X8} {sb.ToString()}", 1, 1) { Tag = hWnd });
                    }
                } catch {
                    // ignore
                }
                return true;
            }, IntPtr.Zero);
            foreach (var kvp in procNodes.OrderBy(kvp => ((Process)kvp.Value.Tag).ProcessName)) {
                if (kvp.Value.Nodes.Count > 0) {
                    kvp.Value.ImageIndex = kvp.Value.SelectedImageIndex = 3;
                } else {
                    kvp.Value.ImageIndex = kvp.Value.SelectedImageIndex = 2;
                    kvp.Value.ForeColor = Color.Gray;
                }
                treeView.Nodes.Add(kvp.Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e) => refreshButton_Click(sender, e);

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            windowInfoControls.ForEach(c => c.Hide());
            if (e.Node.ImageIndex == 1) {
                var hWnd = (IntPtr)e.Node.Tag;
                if (GetWindowRect(new HandleRef(this, hWnd), out var rct) && NotEmpty(rct)) {
                    var w = rct.Right - rct.Left;
                    origWidth.Text = $"{w}px";
                    widthNud.Value = w;
                    var h = rct.Bottom - rct.Top;
                    origHeight.Text = $"{h}px";
                    heightNud.Value = h;
                    windowInfoControls.ForEach(c => c.Show());
                }
            }
        }

        private void resizeButton_Click(object sender, EventArgs e) {
            var selected = treeView.SelectedNode;
            if (selected != null && selected.ImageIndex == 1) {
                var hWnd = (IntPtr)selected.Tag;
                if (GetWindowRect(new HandleRef(this, hWnd), out var rct)) {
                    MoveWindow(hWnd, rct.Left, rct.Top, (int)widthNud.Value, (int)heightNud.Value, true);
                    GetWindowRect(new HandleRef(this, hWnd), out var rct2);
                    var w = rct2.Right - rct2.Left;
                    origWidth.Text = $"{w}px";
                    widthNud.Value = w;
                    var h = rct2.Bottom - rct2.Top;
                    origHeight.Text = $"{h}px";
                    heightNud.Value = h;
                } else MessageBox.Show("Error has appeared.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
