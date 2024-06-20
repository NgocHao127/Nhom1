using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBanVeMayBay.BUS;
using AppBanVeMayBay.BUS.BUS_QL;
using AppBanVeMayBay.DTO;

namespace AppBanVeMayBay.GUI.GUI_QUANLY
{
    public partial class FormDanhSachNhanVien : Form
    {
        DanhSachNhanVienBUS dsnvBus;
        nhanvienDTO dsnv_nvDto;
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }
        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            //Thiết lập chuỗi kết nối
            DataProvider.connectionString = @"Data Source=MAYTINH-VC21J73\SQLEXPRESS;Initial Catalog=QLMayBay;Integrated Security=True;";
            DataProvider provider = new DataProvider();
            provider.connect();
            //Từ câu lệnh này conn sẽ được thiết lặp và có thể gọi DataProvider.conn
            dsnvBus = new DanhSachNhanVienBUS();
            dsnv_nvDto = new nhanvienDTO();

            dgvdsnv.DataSource = dsnvBus.getDSKhachHang();
        }
    }
}
