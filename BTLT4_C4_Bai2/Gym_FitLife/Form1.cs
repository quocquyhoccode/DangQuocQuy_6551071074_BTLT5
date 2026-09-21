namespace Gym_FitLife
{
    public partial class frmGymFitFlife : Form
    {
        public frmGymFitFlife()
        {
            InitializeComponent();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Họ tên: " + txtHoTen.Text +
                    "\nSĐT: " + txtSDT.Text +
                    "\nGói tập: " + cboGoiTap.Text +
                    "\nSố buổi/tuần: " + numSoBuoiTuan.Value,
                    "Thông tin đăng ký",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
