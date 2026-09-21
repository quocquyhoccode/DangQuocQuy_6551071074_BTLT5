namespace CafeStatusDemo
{
    partial class frmCafe
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDoiMauNen = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblGioHienTai = new ToolStripStatusLabel();
            lblTenQuan = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDoiMauNen, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDoiMauNen
            // 
            mnuDoiMauNen.Name = "mnuDoiMauNen";
            mnuDoiMauNen.Size = new Size(177, 26);
            mnuDoiMauNen.Text = "Đổi màu nền";
            mnuDoiMauNen.Click += mnuDoiMauNen_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(177, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblGioHienTai
            // 
            lblGioHienTai.Name = "lblGioHienTai";
            lblGioHienTai.Overflow = ToolStripItemOverflow.Never;
            lblGioHienTai.Size = new Size(261, 20);
            lblGioHienTai.Spring = true;
            lblGioHienTai.Text = "Giờ Hiện Tại";
            lblGioHienTai.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTenQuan
            // 
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Overflow = ToolStripItemOverflow.Never;
            lblTenQuan.Size = new Size(261, 20);
            lblTenQuan.Spring = true;
            lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Overflow = ToolStripItemOverflow.Never;
            lblTrangThai.Size = new Size(261, 20);
            lblTrangThai.Spring = true;
            lblTrangThai.Text = "Đang mở cửa";
            lblTrangThai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmCafe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCafe";
            Text = "Form1";
            Load += frmCafe_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDoiMauNen;
        private ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblGioHienTai;
        private ToolStripStatusLabel lblTenQuan;
        private ToolStripStatusLabel lblTrangThai;
    }
}
