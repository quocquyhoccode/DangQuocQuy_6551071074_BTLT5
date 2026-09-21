namespace QuanLyBanHang
{
    partial class frmBanHang
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
            btnThem = new Button();
            btnXoaTrang = new Button();
            lblMaSP = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Location = new Point(154, 329);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(147, 109);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaTrang.Location = new Point(439, 329);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(145, 109);
            btnXoaTrang.TabIndex = 1;
            btnXoaTrang.Text = "Xóa Trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSP.Location = new Point(125, 48);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(108, 20);
            lblMaSP.TabIndex = 2;
            lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoLuong.Location = new Point(125, 96);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(79, 20);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDonGia.Location = new Point(125, 157);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(69, 20);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn Giá:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(491, 45);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(169, 27);
            txtMaSP.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(491, 93);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(169, 27);
            txtSoLuong.TabIndex = 6;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(491, 154);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(169, 27);
            txtDonGia.TabIndex = 7;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(154, 200);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(423, 104);
            lstKetQua.TabIndex = 8;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblMaSP);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            KeyPreview = true;
            Name = "frmBanHang";
            Text = "Quản Lý Bán Hàng";
            KeyDown += frmBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnXoaTrang;
        private Label lblMaSP;
        private Label lblSoLuong;
        private Label lblDonGia;
        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private ListBox lstKetQua;
    }
}
