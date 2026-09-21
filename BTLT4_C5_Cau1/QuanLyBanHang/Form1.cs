namespace QuanLyBanHang
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dong = txtMaSP.Text + " | "
            + txtSoLuong.Text + " | "
            + txtDonGia.Text;

            lstKetQua.Items.Add(dong);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtMaSP.Focus();
        }

        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult kq = MessageBox.Show(
                    "Ban co muon thoat?",
                    "Thong bao",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
