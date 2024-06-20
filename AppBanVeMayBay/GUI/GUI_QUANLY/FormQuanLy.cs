using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVeMayBay.GUI.GUI_QUANLY
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }
        //tạo và mở các form con trong form trang chủ
        private System.Windows.Forms.Form sofrmcon;
        private void mofrmcon(System.Windows.Forms.Form frmcon)
        {
            if (sofrmcon != null)
            {
                sofrmcon.Close();
            }
            sofrmcon = frmcon;
            frmcon.TopLevel = false;
            frmcon.FormBorderStyle = FormBorderStyle.None;
            frmcon.Dock = DockStyle.Fill;
            panel_body.Controls.Add(frmcon);
            panel_body.Tag = frmcon;
            frmcon.BringToFront();
            frmcon.Show();
        }
        //bấm vào logo thì mở lại trang chủ
        private void ptb_logo_Click(object sender, EventArgs e)
        {
            if (sofrmcon != null)
            {
                sofrmcon.Close();
            }
            label1.Text = "Danh Sách Vé";
        }
        private void btndanhsachkhachhang_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormDanhSachKhachHang());
            label1.Text = btndanhsachkhachhang.Text;
        }
        private void btndanhsachnhanvien_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormDanhSachNhanVien());
            label1.Text = btndanhsachnhanvien.Text;
        }
        private void btnthongtintaikhoan_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormThongTinTaiKhoanQL());
            label1.Text = btnthongtintaikhoan.Text;
        }
        //bấm vào chữ trang chủ thì mở lại trang chủ
        private void label1_Click(object sender, EventArgs e)
        {
            if (sofrmcon != null)
            {
                sofrmcon.Close();
            }
            label1.Text = "Danh Sách Vé";
        }
        private void btndangxuat_Click(object sender, EventArgs e)
        {
            FormDangNhapQL formDangNhapQL = new FormDangNhapQL();
            FormQuanLy formQuanLy = new FormQuanLy();
            formQuanLy.Hide();
            formDangNhapQL.Show();
        }
    }
}
