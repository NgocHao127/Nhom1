using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVeMayBay.GUI.GUI_KHACHHANG
{
    public partial class FormDangNhapKH : Form
    {
        public FormDangNhapKH()
        {
            InitializeComponent();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttentaikhoan.Text) || string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
            }
        }
        private void linkdangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
        }
        private void linkquenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            FormDangNhapQL formDangNhapQL = new FormDangNhapQL();
            FormDangNhapKH formDangNhapKH = new FormDangNhapKH();
            formTrangChu.Hide();
            formDangNhapKH.Hide();
            formDangNhapQL.Show();
        }
    }
}
