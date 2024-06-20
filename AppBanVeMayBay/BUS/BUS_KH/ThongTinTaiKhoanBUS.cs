using AppBanVeMayBay.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVeMayBay.BUS
{
    internal class ThongTinTaiKhoanBUS
    {
        //Để truy xuất xuống CSDL
        private ThongTinTaiKhoanDAO data = new ThongTinTaiKhoanDAO();
        //Chứa thông tin của 1 học sinh
        public ThongTinTaiKhoanBUS info { get; set; }
        public DataTable getDSVeKH()
        {
            return data.getDSVeKH();
        }
    }
}
