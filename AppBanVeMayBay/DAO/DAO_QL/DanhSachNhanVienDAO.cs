using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DAO.DAO_QL
{
    internal class DanhSachNhanVienDAO
    {
        private DataProvider _provider = new DataProvider();
        public DanhSachNhanVienDAO()
        {
            //_provider.connect();
        }
        //Lấy toàn bộ danh sách phim
        public DataTable getDSNhanVien()
        {
            string sqlStr = "Select * from nhanvien";
            return _provider.executeQuery(sqlStr);
        }
    }
}
