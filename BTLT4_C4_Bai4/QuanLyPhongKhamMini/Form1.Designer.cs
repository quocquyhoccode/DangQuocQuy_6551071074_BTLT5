namespace QuanLyPhongKhamMini
{
    partial class frmQuanLyPhongKhamMini
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
            mnuStrip = new MenuStrip();
            mnuNghiepVu = new ToolStripMenuItem();
            mnuThongTinBenhNhan = new ToolStripMenuItem();
            mnuDatLichHen = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuNghiepVu, mnuCuaSo });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.MdiWindowListItem = mnuCuaSo;
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(800, 28);
            mnuStrip.TabIndex = 1;
            mnuStrip.Text = "menuStrip1";
            // 
            // mnuNghiepVu
            // 
            mnuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinBenhNhan, mnuDatLichHen });
            mnuNghiepVu.Name = "mnuNghiepVu";
            mnuNghiepVu.Size = new Size(93, 24);
            mnuNghiepVu.Text = "Nghiệp Vụ";
            // 
            // mnuThongTinBenhNhan
            // 
            mnuThongTinBenhNhan.Name = "mnuThongTinBenhNhan";
            mnuThongTinBenhNhan.Size = new Size(228, 26);
            mnuThongTinBenhNhan.Text = "Thông tin bệnh nhân";
            mnuThongTinBenhNhan.Click += mnuThongTinBenhNhan_Click;
            // 
            // mnuDatLichHen
            // 
            mnuDatLichHen.Name = "mnuDatLichHen";
            mnuDatLichHen.Size = new Size(228, 26);
            mnuDatLichHen.Text = "Đặt lịch hẹn";
            mnuDatLichHen.Click += mnuDatLichHen_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(68, 24);
            mnuCuaSo.Text = "Cửa sổ";
            // 
            // frmQuanLyPhongKhamMini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuStrip);
            IsMdiContainer = true;
            MainMenuStrip = mnuStrip;
            Name = "frmQuanLyPhongKhamMini";
            Text = "Quản Lý Phòng Khám Mini";
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuStrip;
        private ToolStripMenuItem mnuNghiepVu;
        private ToolStripMenuItem mnuThongTinBenhNhan;
        private ToolStripMenuItem mnuDatLichHen;
        private ToolStripMenuItem mnuCuaSo;
    }
}
