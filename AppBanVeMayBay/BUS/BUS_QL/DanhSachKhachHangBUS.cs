using AppBanVeMayBay.DAO;
using AppBanVeMayBay.DAO.DAO_QL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.BUS.BUS_QL
{
    internal class DanhSachKhachHangBUS
    {
        //Để truy xuất xuống CSDL
        private DanhSachKhachHangDAO data = new DanhSachKhachHangDAO();
        //Chứa thông tin của 1 học sinh
        public DanhSachKhachHangBUS info { get; set; }
        public DataTable getDSKhachHang()
        {
            return data.getDSKhachHang();
        }
    }
}
