namespace WindowResizer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeView = new System.Windows.Forms.TreeView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resizeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.widthNud = new System.Windows.Forms.NumericUpDown();
            this.heightNud = new System.Windows.Forms.NumericUpDown();
            this.origWidth = new System.Windows.Forms.Label();
            this.origHeight = new System.Windows.Forms.Label();
            this.showAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.tableLayoutPanel1.SetRowSpan(this.treeView, 6);
            this.treeView.Size = new System.Drawing.Size(338, 393);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // refreshButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.refreshButton, 3);
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Location = new System.Drawing.Point(347, 366);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(338, 30);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(347, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(347, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resizeButton
            // 
            this.resizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizeButton.Location = new System.Drawing.Point(483, 59);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(202, 30);
            this.resizeButton.TabIndex = 6;
            this.resizeButton.Text = "Resize";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.refreshButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.widthNud, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.heightNud, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.origWidth, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.origHeight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.resizeButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.showAll, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 399);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // widthNud
            // 
            this.widthNud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthNud.Location = new System.Drawing.Point(483, 3);
            this.widthNud.Maximum = new decimal(new int[] {
            2560,
            0,
            0,
            0});
            this.widthNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNud.Name = "widthNud";
            this.widthNud.Size = new System.Drawing.Size(202, 22);
            this.widthNud.TabIndex = 7;
            this.widthNud.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // heightNud
            // 
            this.heightNud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightNud.Location = new System.Drawing.Point(483, 31);
            this.heightNud.Maximum = new decimal(new int[] {
            2560,
            0,
            0,
            0});
            this.heightNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNud.Name = "heightNud";
            this.heightNud.Size = new System.Drawing.Size(202, 22);
            this.heightNud.TabIndex = 8;
            this.heightNud.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // origWidth
            // 
            this.origWidth.AutoSize = true;
            this.origWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origWidth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.origWidth.Location = new System.Drawing.Point(415, 0);
            this.origWidth.Name = "origWidth";
            this.origWidth.Size = new System.Drawing.Size(62, 28);
            this.origWidth.TabIndex = 9;
            this.origWidth.Text = "width";
            this.origWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // origHeight
            // 
            this.origHeight.AutoSize = true;
            this.origHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origHeight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.origHeight.Location = new System.Drawing.Point(415, 28);
            this.origHeight.Name = "origHeight";
            this.origHeight.Size = new System.Drawing.Size(62, 28);
            this.origHeight.TabIndex = 10;
            this.origHeight.Text = "height";
            this.origHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showAll
            // 
            this.showAll.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.showAll, 3);
            this.showAll.Location = new System.Drawing.Point(347, 342);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(224, 18);
            this.showAll.TabIndex = 11;
            this.showAll.Text = "Show all processes and windows";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.CheckedChanged += new System.EventHandler(this.showAll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(688, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 192);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Window Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown widthNud;
        private System.Windows.Forms.NumericUpDown heightNud;
        private System.Windows.Forms.Label origWidth;
        private System.Windows.Forms.Label origHeight;
        private System.Windows.Forms.CheckBox showAll;
    }
}

