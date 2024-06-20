using AppBanVeMayBay.GUI.GUI_KHACHHANG;
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
    public partial class FormTrangChu : System.Windows.Forms.Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            //label trong suot
            label2.Parent = ptbtrangchu;
            label2.BackColor = Color.Transparent;
            btndangnhap.Show();
            btndangxuat.Hide();
        }
        //tạo và mở các form con trong form trang chủ
        private System.Windows.Forms.Form sofrmcon;
        private void mofrmcon(System.Windows.Forms.Form frmcon)
        {
            if(sofrmcon  != null)
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
            label1.Text = "Trang Chủ";
        }
        private void formtimve_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormTimVe());
            label1.Text = btntimve.Text;
        }
        private void formlichsugiaodich_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormThongTinTaiKhoan());
            label1.Text = btnthongtintaikhoan.Text;
        }
        private void formthongtintaikhoan_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormHoTroKhachHang());
            label1.Text=btncauhoithuonggap.Text;
        }
        //bấm vào chữ trang chủ thì mở lại trang chủ
        private void label1_Click(object sender, EventArgs e)
        {
            if (sofrmcon != null)
            {
                sofrmcon.Close();
            }
            label1.Text = "Trang Chủ";
        }
        //bấm vào nút tìm các điểm đến khác thì mở form vé
        private void button1_Click(object sender, EventArgs e)
        {
            mofrmcon(new FormTimVe());
            label1.Text = btntimve.Text;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            FormDangNhapKH formDangNhapKH = new FormDangNhapKH();
            formDangNhapKH.ShowDialog();
            btndangnhap.Hide();
            btndangxuat.Show();
        }
        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Thực hiện lưu thay đổi
                btndangxuat.Hide();
                btndangnhap.Show();
                FormDangNhapKH formDangNhapKH = new FormDangNhapKH();
                FormTrangChu formTrangChu = new FormTrangChu();
                MessageBox.Show("Đăng xuất thành công.");
            }
        }
    }
}
