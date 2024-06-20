using AppBanVeMayBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.BUS
{
    internal class TimVeBUS
    {
        //Để truy xuất xuống CSDL
        private TimVeDAO data = new TimVeDAO();
        //Chứa thông tin của 1 học sinh
        public TimVeBUS info { get; set; }
        public DataTable getDSThongTinVe()
        {
            return data.getDSThongTinVe();
        }
    }
}
