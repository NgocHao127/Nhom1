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
    public partial class FormHoTroKhachHang : System.Windows.Forms.Form
    {
        public FormHoTroKhachHang()
        {
            InitializeComponent();
            label1.AutoSize = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            linkLabel1.VisitedLinkColor = Color.Blue;
        }
        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            linkLabel1.VisitedLinkColor = Color.White;
        }
        private void linkLabel_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            linkLabel1.VisitedLinkColor = Color.Blue;
        }
        private void linkLabel_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            linkLabel1.VisitedLinkColor = Color.White;
        }
    }
}
