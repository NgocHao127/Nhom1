using AppBanVeMayBay.BUS;
using AppBanVeMayBay.BUS.BUS_QL;
using AppBanVeMayBay.DTO;
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
    public partial class FormDanhSachKhachHang : Form
    {
        DanhSachKhachHangBUS dskhBus;
        khachhangDTO dskh_khDto;
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }
        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            //Thiết lập chuỗi kết nối
            DataProvider.connectionString = @"Data Source=MAYTINH-VC21J73\SQLEXPRESS;Initial Catalog=QLMayBay;Integrated Security=True;";
            DataProvider provider = new DataProvider();
            provider.connect();
            //Từ câu lệnh này conn sẽ được thiết lặp và có thể gọi DataProvider.conn
            dskhBus = new DanhSachKhachHangBUS();
            dskh_khDto = new khachhangDTO();

            dgvdskhachhang.DataSource = dskhBus.getDSKhachHang();
        }
    }
}
