using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppBanVeMayBay.DTO
{
    internal class nhanvienDTO
    {
        public string manhanvien { get; set; }
        public string tennhanvien { get; set; }
        public string sdt { get; set; }
        public string gioitinh { get; set; }
        public string email { get; set; }
        public DateTime ngaysinh { get; set; }
		public string tinhtrang { get; set; }
        public string loainhanvien { get; set; }
        //FK_
        public int maquanly { get; set; }
    }
}
