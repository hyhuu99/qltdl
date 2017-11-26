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

namespace qltdl.view
{
    public partial class quanlytour : UserControl
    {
        public quanlytour()
        {
            InitializeComponent();
            autott();
            
        }
        int rowindex = -1;
        private void qltbt1_Click(object sender, EventArgs e)
        {
            
            
        }
        private void autott()
        {
            NOITHAMQUAN_BUS ntq = new NOITHAMQUAN_BUS();
            //cbb2.AutoCompleteSource= AutoCompleteSource.CustomSource;
            //cbb2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            //col.AddRange(ntq.auto().ToArray());
            //cbb2.AutoCompleteCustomSource = col;
            cbb2.DataSource = ntq.auto();
        }
        private void autodd(String tg)
        {
            cbb3.ResetText();
            CTNTQ_BUS ctntq = new CTNTQ_BUS();
            cbb3.DataSource = ctntq.auto(tg);
        }

        private void cbb2_TextChanged(object sender, EventArgs e)
        {
            String tt = cbb2.Text.ToString();
            autodd(tt);
        }

        private void qlbt3_Click(object sender, EventArgs e)
        {
            try
            {
                if(checktt(cbb3.Text)==0)
                {
                    MessageBox.Show("Địa điểm bị trùng", "Thông báo");
                }
                else 
                    if(String.IsNullOrEmpty(cbb3.Text))
                {
                    MessageBox.Show("Chưa điền địa điểm", "Thông báo");
                }
                else
                {
                    this.dtgtt.Rows.Add(cbb2.Text, cbb3.Text);
                }              
                //this.dtgtt.DataSource = null;
                //this.dtgtt.Rows.Clear();
                //this.dtgtt.Refresh();
                //DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                //col1.HeaderText = "Tỉnh thành";
                //col1.Name = "dtgtt1";
                //col1.Visible = true;
                //DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                //col2.HeaderText = "Địa điểm";
                //col2.Name = "dtgtt2";
                //col2.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void qlbt4_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgtt.Rows[rowindex];
                this.dtgtt.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int checktt(String dd)
        {
            int rowcount = this.dtgtt.Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {
                String dd2 = dtgtt.Rows[i].Cells[1].FormattedValue.ToString();
                if (dd.Equals(dd2))
                    return 0;
            }
            return 1;
        }

        private void dtgtt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }
    }
}
