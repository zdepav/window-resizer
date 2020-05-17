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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.origX = new System.Windows.Forms.Label();
            this.origY = new System.Windows.Forms.Label();
            this.widthNud = new System.Windows.Forms.NumericUpDown();
            this.heightNud = new System.Windows.Forms.NumericUpDown();
            this.origWidth = new System.Windows.Forms.Label();
            this.origHeight = new System.Windows.Forms.Label();
            this.showAll = new System.Windows.Forms.CheckBox();
            this.xNud = new System.Windows.Forms.NumericUpDown();
            this.yNud = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.tableLayoutPanel1.SetRowSpan(this.treeView, 8);
            this.treeView.Size = new System.Drawing.Size(346, 435);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // refreshButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.refreshButton, 3);
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Location = new System.Drawing.Point(355, 408);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(346, 30);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(355, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(355, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resizeButton
            // 
            this.resizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizeButton.Location = new System.Drawing.Point(495, 115);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(206, 30);
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.origX, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.origY, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.refreshButton, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.widthNud, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.heightNud, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.origWidth, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.origHeight, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.resizeButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.showAll, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.xNud, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.yNud, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 441);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(355, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Top:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(355, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Left:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // origX
            // 
            this.origX.AutoSize = true;
            this.origX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origX.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.origX.Location = new System.Drawing.Point(425, 0);
            this.origX.Name = "origX";
            this.origX.Size = new System.Drawing.Size(64, 28);
            this.origX.TabIndex = 15;
            this.origX.Text = "x";
            this.origX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // origY
            // 
            this.origY.AutoSize = true;
            this.origY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origY.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.origY.Location = new System.Drawing.Point(425, 28);
            this.origY.Name = "origY";
            this.origY.Size = new System.Drawing.Size(64, 28);
            this.origY.TabIndex = 14;
            this.origY.Text = "y";
            this.origY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthNud
            // 
            this.widthNud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthNud.Location = new System.Drawing.Point(495, 59);
            this.widthNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNud.Name = "widthNud";
            this.widthNud.Size = new System.Drawing.Size(206, 22);
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
            this.heightNud.Location = new System.Drawing.Point(495, 87);
            this.heightNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNud.Name = "heightNud";
            this.heightNud.Size = new System.Drawing.Size(206, 22);
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
            this.origWidth.Location = new System.Drawing.Point(425, 56);
            this.origWidth.Name = "origWidth";
            this.origWidth.Size = new System.Drawing.Size(64, 28);
            this.origWidth.TabIndex = 9;
            this.origWidth.Text = "width";
            this.origWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // origHeight
            // 
            this.origHeight.AutoSize = true;
            this.origHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origHeight.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.origHeight.Location = new System.Drawing.Point(425, 84);
            this.origHeight.Name = "origHeight";
            this.origHeight.Size = new System.Drawing.Size(64, 28);
            this.origHeight.TabIndex = 10;
            this.origHeight.Text = "height";
            this.origHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showAll
            // 
            this.showAll.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.showAll, 3);
            this.showAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showAll.Location = new System.Drawing.Point(355, 382);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(346, 20);
            this.showAll.TabIndex = 11;
            this.showAll.Text = "Show all processes and windows";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.CheckedChanged += new System.EventHandler(this.showAll_CheckedChanged);
            // 
            // xNud
            // 
            this.xNud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xNud.Location = new System.Drawing.Point(495, 3);
            this.xNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xNud.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xNud.Name = "xNud";
            this.xNud.Size = new System.Drawing.Size(206, 22);
            this.xNud.TabIndex = 12;
            // 
            // yNud
            // 
            this.yNud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yNud.Location = new System.Drawing.Point(495, 31);
            this.yNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yNud.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.yNud.Name = "yNud";
            this.yNud.Size = new System.Drawing.Size(206, 22);
            this.yNud.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox, 3);
            this.pictureBox.Location = new System.Drawing.Point(355, 151);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(346, 225);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(640, 256);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Window Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label origX;
        private System.Windows.Forms.Label origY;
        private System.Windows.Forms.NumericUpDown xNud;
        private System.Windows.Forms.NumericUpDown yNud;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

