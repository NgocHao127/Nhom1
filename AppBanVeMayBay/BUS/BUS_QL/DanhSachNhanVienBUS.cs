using AppBanVeMayBay.DAO.DAO_QL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.BUS.BUS_QL
{
    internal class DanhSachNhanVienBUS
    {
        //Để truy xuất xuống CSDL
        private DanhSachNhanVienDAO data = new DanhSachNhanVienDAO();
        //Chứa thông tin của 1 học sinh
        public DanhSachNhanVienBUS info { get; set; }
        public DataTable getDSKhachHang()
        {
            return data.getDSNhanVien();
        }
    }
}
