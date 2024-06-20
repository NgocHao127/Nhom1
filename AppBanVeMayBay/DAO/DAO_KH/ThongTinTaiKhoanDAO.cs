using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DAO
{
    internal class ThongTinTaiKhoanDAO
    {
        private DataProvider _provider = new DataProvider();
        public ThongTinTaiKhoanDAO()
        {
            //_provider.connect();
        }
        //Lấy toàn bộ danh sách phim
        public DataTable getDSVeKH()
        {
            string sqlStr = "Select v.mave,v.loaive,v.giave,v.ngaydi,v.ngayve,v.tu,v.den,d.loaikhach,d.ghe,d.loaighe from ve v,datve d where v.mave = d.mave";
            return _provider.executeQuery(sqlStr);
        }
    }
}
