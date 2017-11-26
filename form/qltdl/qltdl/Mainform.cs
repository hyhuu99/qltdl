using qltdl.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace qltdl
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            dockview();
        }
        thongketour tkt = new thongketour();
        quanlytour qlt=new quanlytour();
        //dockview
        private void dockview()
        {
            pnqlt.Controls.Add(qlt);
            pntkt.Controls.Add(tkt);
            qlt.Dock = DockStyle.Fill;
        }
        private void tktbt_Click(object sender, EventArgs e)
        {
            this.pnqlt.Visible = false;
            this.pnqlt.Visible = false;
            pnqlt.Controls.Add(tkt);
            tkt.Dock = DockStyle.Fill;
            this.tkt.Visible = true;
        }

        private void qltbt_Click(object sender, EventArgs e)
        {
            this.pnqlt.Visible = false;
            pnqlt.Controls.Add(qlt);
            qlt.Dock = DockStyle.Fill;
            this.qlt.Visible = true;
        }
    }
}
