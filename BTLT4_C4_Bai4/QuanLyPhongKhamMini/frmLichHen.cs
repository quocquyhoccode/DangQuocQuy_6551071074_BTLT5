using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongKhamMini
{
    public partial class frmLichHen : Form
    {
        public frmLichHen()
        {
            InitializeComponent();
        }

        private List<string> danhSachLichHen = new List<string>();

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string tenBenhNhan = txtTenBenhNhan.Text;

            DateTime ngayGioHen = dtpNgayGioHen.Value;

            string lichHen = tenBenhNhan + " - " +
                             ngayGioHen.ToString("dd/MM/yyyy HH:mm");

            danhSachLichHen.Add(lichHen);
            lstLichHen.Items.Add(lichHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
