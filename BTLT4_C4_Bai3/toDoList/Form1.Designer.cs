namespace toDoList
{
    partial class frmToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnThem = new Button();
            lblCongViec = new Label();
            txtCongViecMoi = new TextBox();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            mnuDanhDau = new ToolStripMenuItem();
            mnuXoa = new ToolStripMenuItem();
            mnuXoaTatCa = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(604, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblCongViec
            // 
            lblCongViec.AutoSize = true;
            lblCongViec.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCongViec.Location = new Point(78, 43);
            lblCongViec.Name = "lblCongViec";
            lblCongViec.Size = new Size(113, 20);
            lblCongViec.TabIndex = 1;
            lblCongViec.Text = "Công Việc Mới:";
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(226, 41);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(333, 27);
            txtCongViecMoi.TabIndex = 2;
            // 
            // lstCongViec
            // 
            lstCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(33, 94);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(647, 204);
            lstCongViec.TabIndex = 3;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { mnuDanhDau, mnuXoa, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            // 
            // mnuDanhDau
            // 
            mnuDanhDau.Name = "mnuDanhDau";
            mnuDanhDau.Size = new Size(220, 24);
            mnuDanhDau.Text = "Đánh dấu hoàn thành";
            mnuDanhDau.Click += mnuDanhDau_Click;
            // 
            // mnuXoa
            // 
            mnuXoa.Name = "mnuXoa";
            mnuXoa.Size = new Size(220, 24);
            mnuXoa.Text = "Xóa công việc này";
            mnuXoa.Click += mnuXoa_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new Size(220, 24);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 361);
            Controls.Add(lstCongViec);
            Controls.Add(txtCongViecMoi);
            Controls.Add(lblCongViec);
            Controls.Add(btnThem);
            Name = "frmToDoList";
            Text = "To-Do-List";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Label lblCongViec;
        private TextBox txtCongViecMoi;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem mnuDanhDau;
        private ToolStripMenuItem mnuXoa;
        private ToolStripMenuItem mnuXoaTatCa;
    }
}
