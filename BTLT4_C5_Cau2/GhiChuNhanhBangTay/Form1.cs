namespace GhiChuNhanhBangTay
{
    public partial class frmGhiChuNhanhBangtay : Form
    {

        bool dangVe = false;
        Point diemCu;
        Graphics g;
        public frmGhiChuNhanhBangtay()
        {
            InitializeComponent();
        }

        private void frmGhiChuNhanhBangtay_Load(object sender, EventArgs e)
        {
            g = pnlCanvas.CreateGraphics();
            lblTrangThai.Text = "San sang";
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemCu = e.Location;
                lblTrangThai.Text = "Dang ve...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = "X = " + e.X + " , Y = " + e.Y;

            if (dangVe)
            {
                g.DrawLine(Pens.Black, diemCu, e.Location);
                diemCu = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            dangVe = false;
            lblTrangThai.Text = "San sang";
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();
                lblTrangThai.Text = "San sang";
            }
        }
    }
}
