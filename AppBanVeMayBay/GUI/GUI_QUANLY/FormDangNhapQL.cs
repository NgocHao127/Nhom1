using AppBanVeMayBay.GUI.GUI_KHACHHANG;
using AppBanVeMayBay.GUI.GUI_QUANLY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVeMayBay
{
    public partial class FormDangNhapQL : System.Windows.Forms.Form
    {
        public FormDangNhapQL()
        {
            InitializeComponent();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttaikhoan.Text) || string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                FormQuanLy formQuanLy = new FormQuanLy();
                formQuanLy.Show();
            }
        }

        private void linkquestion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangNhapKH formDangNhapKH = new FormDangNhapKH();
            FormDangNhapQL formDangNhapQL = new FormDangNhapQL();
            formDangNhapQL.Hide();
            formDangNhapKH.Show();
        }
    }
}
