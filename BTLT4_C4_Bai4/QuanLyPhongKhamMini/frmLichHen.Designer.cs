namespace QuanLyPhongKhamMini
{
    partial class frmLichHen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpNgayGioHen = new DateTimePicker();
            lblTenBenhNhan = new Label();
            lblNgayGioHen = new Label();
            lstLichHen = new ListBox();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            SuspendLayout();
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.Location = new Point(367, 123);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(214, 27);
            dtpNgayGioHen.TabIndex = 0;
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenBenhNhan.Location = new Point(130, 64);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(118, 20);
            lblTenBenhNhan.TabIndex = 1;
            lblTenBenhNhan.Text = "tên Bệnh Nhân:";
            // 
            // lblNgayGioHen
            // 
            lblNgayGioHen.AutoSize = true;
            lblNgayGioHen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayGioHen.Location = new Point(130, 130);
            lblNgayGioHen.Name = "lblNgayGioHen";
            lblNgayGioHen.Size = new Size(110, 20);
            lblNgayGioHen.TabIndex = 2;
            lblNgayGioHen.Text = "Ngày Giờ Hẹn:";
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(130, 197);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(472, 124);
            lstLichHen.TabIndex = 3;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(367, 61);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(235, 27);
            txtTenBenhNhan.TabIndex = 4;
            // 
            // btnDatLich
            // 
            btnDatLich.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDatLich.Location = new Point(324, 360);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(96, 48);
            btnDatLich.TabIndex = 5;
            btnDatLich.Text = "Đặt Lịch:";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lstLichHen);
            Controls.Add(lblNgayGioHen);
            Controls.Add(lblTenBenhNhan);
            Controls.Add(dtpNgayGioHen);
            Name = "frmLichHen";
            Text = "Lịch Hẹn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGioHen;
        private Label lblTenBenhNhan;
        private Label lblNgayGioHen;
        private ListBox lstLichHen;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
    }
}