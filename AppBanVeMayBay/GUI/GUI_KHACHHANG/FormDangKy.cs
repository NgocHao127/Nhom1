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
    public partial class FormDangKy : System.Windows.Forms.Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txttentaikhoan.Text) || string.IsNullOrEmpty(txtten.Text) || string.IsNullOrEmpty(txtcccd.Text) || string.IsNullOrEmpty(txtdienthoai.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtngaythangnamsinh.Text) || string.IsNullOrEmpty(txtquoctich.Text) || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtmatkhau.Text) || string.IsNullOrEmpty(txtxacnhanlaimatkhau.Text) || (!cbnam.Checked && !cbnu.Checked))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                MessageBox.Show("Tài khoản đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
        }

        private void lbhovadem_Click(object sender, EventArgs e)
        {

        }

        private void lbnamsinh_Click(object sender, EventArgs e)
        {

        }
    }
}
