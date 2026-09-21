namespace Gym_FitLife
{
    partial class frmGymFitFlife
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
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblNgaySinh = new Label();
            lblBuoiTap = new Label();
            lblGoiTap = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(345, 39);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(290, 27);
            txtHoTen.TabIndex = 0;
            toolTip1.SetToolTip(txtHoTen, "Nhập họ tên hội viên");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(345, 87);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(290, 27);
            txtSDT.TabIndex = 1;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(345, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 27);
            txtEmail.TabIndex = 2;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(385, 195);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // cboGoiTap
            // 
            cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(484, 295);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(151, 28);
            cboGoiTap.TabIndex = 4;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(493, 248);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(142, 27);
            numSoBuoiTuan.TabIndex = 5;
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDangKy.Location = new Point(314, 363);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(131, 56);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.Location = new Point(97, 42);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(62, 20);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ Tên:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSDT.Location = new Point(97, 90);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(109, 20);
            lblSDT.TabIndex = 8;
            lblSDT.Text = "Số Điện Thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(97, 138);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(97, 200);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(84, 20);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblBuoiTap
            // 
            lblBuoiTap.AutoSize = true;
            lblBuoiTap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuoiTap.Location = new Point(97, 250);
            lblBuoiTap.Name = "lblBuoiTap";
            lblBuoiTap.Size = new Size(75, 20);
            lblBuoiTap.TabIndex = 11;
            lblBuoiTap.Text = "Buổi Tập:";
            // 
            // lblGoiTap
            // 
            lblGoiTap.AutoSize = true;
            lblGoiTap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGoiTap.Location = new Point(97, 298);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(67, 20);
            lblGoiTap.TabIndex = 12;
            lblGoiTap.Text = "Gói Tập:";
            // 
            // frmGymFitFlife
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGoiTap);
            Controls.Add(lblBuoiTap);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "frmGymFitFlife";
            Text = "Gym FitLife";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGoiTap;
        private NumericUpDown numSoBuoiTuan;
        private Button btnDangKy;
        private ToolTip toolTip1;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblNgaySinh;
        private Label lblBuoiTap;
        private Label lblGoiTap;
    }
}
