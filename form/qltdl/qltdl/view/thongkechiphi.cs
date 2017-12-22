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
        int idt = -1;
        private void load()
        {
            QLTOUR_BUS qlt = new QLTOUR_BUS();
            List<TOUR> lt = qlt.GetAll();
            dttour.DataSource = lt;
            dttour.Columns["ID"].Visible = false;
            dttour.Columns["IDL"].Visible = false;
            dttour.Columns["DOANDLs"].Visible = false;
            dttour.Columns["GIATOURs"].Visible = false;
            dttour.Columns["LOAITOUR"].Visible = false;
            dttour.Columns["TOURDDs"].Visible = false;

            if (!lt.Any())
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
        }
        private void dttkt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;
                idt = int.Parse(this.dttour.CurrentRow.Cells[0].Value.ToString());
                loaddd(idt);            
                bttk.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }
        private void loaddd(int id)
        {
            TOURDD_BUS tdd = new TOURDD_BUS();
            List<ddview> lddv = new List<ddview>();
            lddv = tdd.load(id);
            this.dtgtt.DataSource = lddv;
            if (!lddv.Any())
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);

        }
        private void bttk_Click(object sender, EventArgs e)
        {
            try
            {
                CTTT_BUS cttb = new CTTT_BUS();
                List<tkchiphi> ltkcp = cttb.tkchiphi(dp1.Value, dp2.Value, idt);
                this.dtddl.DataSource = ltkcp;
                dtddl.Columns["iddl"].Visible = false;
                if (!ltkcp.Any())
                    MessageBox.Show("Chưa có đoàn du lịch", "Thông báo", MessageBoxButtons.OK);
                this.bttk.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtddl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idddl= int.Parse(this.dtddl.CurrentRow.Cells[3].Value.ToString());
                loadcttt(idddl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadcttt(int idddl)
        {
            CTTT_BUS ctb = new CTTT_BUS();
            List<tkcttt> ltkct = ctb.getlistcttt(idddl);
            this.dttk.DataSource = ltkct;
            if (!ltkct.Any())
                MessageBox.Show("Chưa có phiếu thanh toán", "Thông báo", MessageBoxButtons.OK);
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
