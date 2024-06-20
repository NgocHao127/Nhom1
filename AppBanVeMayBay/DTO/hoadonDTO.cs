using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DTO
{
    internal class hoadonDTO
    {
        public string mahoadon { get; set; }
        public int tienthanhtoan { get; set; }
        //FK_
        public int makhachhang { get; set; }
        //FK_
        public string mave { get; set; }
        public string phuongthucthanhtoan { get; set; }
        //FK_
        public string manhanvien { get; set; }
    }
}
