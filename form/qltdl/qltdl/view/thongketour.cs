using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace qltdl.view
{
    public partial class thongketour : UserControl
    {
        public thongketour()
        {
            InitializeComponent();
            autotour();
        }
        private void autotour()
        {
            QLTOUR_BUS qlt = new QLTOUR_BUS();
            cbb1.DataSource = qlt.auto();
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTOUR_BUS qlt = new QLTOUR_BUS();
            List<tktour> tkt= new List<tktour>();
            tkt = qlt.thongketour(cbb1.Text);
            this.dttkt.DataSource = tkt;
            if (!tkt.Any())
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
