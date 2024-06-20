using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DTO
{
    internal class datveDTO
    {
        public string madatve { get; set; }
        //FK_
        public string mave { get; set; }
        public string loaikhach { get; set; }
        public string ghe { get; set; }
        public string loaighe { get; set; }
        //FK_
        public string mamaybay { get; set; }
        //FK_
        public int makhachhang { get; set; }
    }
}
