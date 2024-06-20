using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanVeMayBay.DTO
{
    internal class veDTO
    {
        public string mave { get; set; }
        public string loaive { get; set; }
        public int sovecon { get; set; }
        public int giave { get; set; }
        public DateTime ngaydi { get; set; }
        public DateTime ngayve { get; set; }
        public string tu { get; set; }
        public string den { get; set; }
        //FK_
        public string mamaybay { get; set; }
        //FK_
        public int maquanly { get; set; }
    }
}
