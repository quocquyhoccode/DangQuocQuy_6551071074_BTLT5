using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongKhamMini
{
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private List<string> danhSachBenhNhan = new List<string>();
        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string hoTen = txtTenBenhNhan.Text;
            int tuoi = (int)nudTuoi.Value;
            string trieuChung = txtTrieuChung.Text;

            string thongTin = hoTen + " - " + tuoi + " tuổi - " + trieuChung;

            lstBenhNhan.Items.Add(thongTin);

            txtTenBenhNhan.Clear();
            nudTuoi.Value = 0;
            txtTrieuChung.Clear();

            txtTenBenhNhan.Focus();
        }
    }
}
