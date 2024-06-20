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
    public partial class FormQuenMatKhau : System.Windows.Forms.Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txttaikhoan.Text) || string.IsNullOrEmpty(txtemail.Text) )
            {
                MessageBox.Show("Cần nhập đủ thông tin cần thiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int randomNumber = new Random((int)DateTime.Now.Ticks).Next(100, 999);
                MessageBox.Show("Đây là mật khẩu mới của tài khoản: "+randomNumber, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }    

        }
    }
}
