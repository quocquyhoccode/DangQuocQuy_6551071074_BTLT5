namespace toDoList
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCongViecMoi.Text != "")
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);

                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void mnuDanhDau_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int index = lstCongViec.SelectedIndex;

                    lstCongViec.Items[index] = "[Hoàn thành] " + congViec;
                }
            }
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                DialogResult kq = MessageBox.Show(
                    "Bạn có chắc muốn xóa công việc này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn công việc cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lstCongViec.Items.Count > 0)
            {
                DialogResult kq = MessageBox.Show(
                    "Bạn có chắc muốn xóa tất cả công việc không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    lstCongViec.Items.Clear();
                }
            }
        }
    }
}
