using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DAO.DAO_QL
{
    internal class DanhSachKhachHangDAO
    {
        private DataProvider _provider = new DataProvider();
        public DanhSachKhachHangDAO()
        {
            //_provider.connect();
        }
        //Lấy toàn bộ danh sách phim
        public DataTable getDSKhachHang()
        {
            string sqlStr = "Select * from khachhang";
            return _provider.executeQuery(sqlStr);
        }
    }
}
