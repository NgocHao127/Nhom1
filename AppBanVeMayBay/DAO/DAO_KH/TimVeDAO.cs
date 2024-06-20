using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DAO
{
    internal class TimVeDAO
    {
        private DataProvider _provider = new DataProvider();
        public TimVeDAO()
        {
            //_provider.connect();
        }
        //Lấy toàn bộ danh sách phim
        public DataTable getDSThongTinVe()
        {
            string sqlStr = "Select v.mave,v.loaive,v.sovecon,v.giave,v.ngaydi,v.ngayve,v.tu,v.den,m.hangbay from ve v,maybay m where v.mamaybay = m.mamaybay";
            return _provider.executeQuery(sqlStr);
        }
    }
}
