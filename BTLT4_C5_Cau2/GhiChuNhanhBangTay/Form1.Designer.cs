namespace GhiChuNhanhBangTay
{
    partial class frmGhiChuNhanhBangtay
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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.Location = new Point(47, 118);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(656, 257);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblViTri.Location = new Point(65, 50);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(49, 20);
            lblViTri.TabIndex = 1;
            lblViTri.Text = "Vị Trí:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTrangThai.Location = new Point(393, 53);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(87, 20);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // frmGhiChuNhanhBangtay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(lblViTri);
            Controls.Add(pnlCanvas);
            Name = "frmGhiChuNhanhBangtay";
            Text = "Ghi Chú Nhanh Bằng Tay";
            Load += frmGhiChuNhanhBangtay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
        private Label lblTrangThai;
    }
}
