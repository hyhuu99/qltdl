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
using System.Diagnostics;

namespace qltdl.view
{
    public partial class thongkechiphi : UserControl
    {
        public thongkechiphi()
        {
            InitializeComponent();
            load();
        }
        int rowindex = -1;
        private void load()
        {
            QLTOUR_BUS qlt = new QLTOUR_BUS();
            List<TOUR> lt = qlt.GetAll();
            dttkt.DataSource = lt;
            dttkt.Columns["ID"].Visible = false;
            dttkt.Columns["IDL"].Visible = false;
            dttkt.Columns["DOANDLs"].Visible = false;
            dttkt.Columns["GIATOURs"].Visible = false;
            dttkt.Columns["LOAITOUR"].Visible = false;
            dttkt.Columns["TOURDDs"].Visible = false;

            if (!lt.Any())
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
        }
        private void dttkt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;
                int id = int.Parse(this.dttkt.CurrentRow.Cells[0].Value.ToString());
                loaddd(id);            
                bttk.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }
        private void loaddd(int i)
        {
            TOURDD_BUS tdd = new TOURDD_BUS();
            List<ddview> lddv = new List<ddview>();
            lddv = tdd.load(i);
            this.dtgtt.DataSource = lddv;
            if (!lddv.Any())
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
