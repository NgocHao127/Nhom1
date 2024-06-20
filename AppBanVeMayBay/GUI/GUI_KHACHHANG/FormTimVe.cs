using AppBanVeMayBay.BUS;
using AppBanVeMayBay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVeMayBay
{
    public partial class FormTimVe : System.Windows.Forms.Form
    {
        TimVeBUS tvBus;
        veDTO tv_veDto;
        public FormTimVe()
        {
            InitializeComponent();
        }

        private void FormTimVe_Load(object sender, EventArgs e)
        {
            //Thiết lập chuỗi kết nối
            DataProvider.connectionString = @"Data Source=MAYTINH-VC21J73\SQLEXPRESS;Initial Catalog=QLMayBay;Integrated Security=True;";
            DataProvider provider = new DataProvider();
            provider.connect();
            //Từ câu lệnh này conn sẽ được thiết lặp và có thể gọi DataProvider.conn
            tvBus = new TimVeBUS();
            tv_veDto = new veDTO();

            dgvve.DataSource = tvBus.getDSThongTinVe();

        }
    }
}
