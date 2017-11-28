﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using viewmodel;
using System.Diagnostics;

namespace qltdl.view
{
    public partial class quanlytour : UserControl
    {
        public quanlytour()
        {
            InitializeComponent();
            autott();
            autoloai();
            load();
            this.qlbt1.Enabled = false;
            this.qlbt4.Enabled = false;

        }
        int rowindex = -1;
        int dkxoa = 0;//1 xoa bảng tỉnh thành, 0 xóa bảng qlt
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
        private void autoloai()
        {
            LOAITOUR_BUS ltb = new LOAITOUR_BUS();
            tb4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(ltb.auto().ToArray());
            cbb2.AutoCompleteCustomSource = col;
        }
        private void cbb2_TextChanged(object sender, EventArgs e)
        {
            String tt = cbb2.Text.ToString();
            autodd(tt);
        }
        private void load()
        {
            try
            {
                QLTOUR_BUS qlt = new QLTOUR_BUS();
                List<tourview> ltv = qlt.load();
                this.dtgt.DataSource = ltv;
                dtgt.Columns["id"].Visible = false;
                
                if (!ltv.Any())
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void qlbt3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb1.Text.Length < 2)
                    MessageBox.Show("Chưa điền tên tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);                              
                else if (tb3.Text.Length < 2)
                    MessageBox.Show("Chưa điền giá tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
                else
                {
                    
                    this.dtgt.Rows.Add(tb1.Text, tb2.Text, int.Parse(tb3.Text), tb4.Text, dp1.Text, dp2.Text);
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
                if(dkxoa==1)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dtgtt.Rows[rowindex];
                    this.dtgtt.Rows.Remove(row);
                }
                else
                    if(dkxoa==0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dtgt.Rows[rowindex];
                    this.dtgt.Rows.Remove(row);
                }
                
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
            dkxoa = 1;
            this.qlbt4.Enabled = true;
        }

        private void qlbt5_Click(object sender, EventArgs e)
        {
            if (checktt(cbb3.Text) == 0)
            {
                MessageBox.Show("Địa điểm bị trùng", "Thông báo");
            }
            else
                  if (String.IsNullOrEmpty(cbb3.Text))
            {
                MessageBox.Show("Chưa điền địa điểm", "Thông báo");
            }
            else
            {
                this.dtgtt.Rows.Add(cbb2.Text, cbb3.Text);
                this.qlbt1.Enabled = true;
            }
        }

        private void dtgt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            rowindex = e.RowIndex;
            dkxoa = 0;
            int id = int.Parse(this.dtgt.CurrentRow.Cells[6].Value.ToString());
            loaddd(id);
            //Debug.WriteLine(this.dtgt.CurrentRow.Cells[6].Value.ToString());
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
        private void qlbt1_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Length < 2)
                MessageBox.Show("Chưa điền tên tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tb3.Text.Length < 2)
                MessageBox.Show("Chưa điền giá tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                  if (String.IsNullOrEmpty(cbb3.Text))
            {
                MessageBox.Show("Chưa điền địa điểm", "Thông báo");
            }
            else
                  if (dp1.Value>dp2.Value)
            {
                MessageBox.Show("ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo");
            }
            else
                if(String.IsNullOrEmpty(dtgtt.Rows[0].Cells[1].FormattedValue.ToString()))
            {
                MessageBox.Show("Chưa điền địa điểm", "Thông báo");
            }
            else
            {
                QLTOUR_BUS qlt = new QLTOUR_BUS();
                GIATOUR_BUS gt = new GIATOUR_BUS();
                LOAITOUR_BUS lt = new LOAITOUR_BUS();
                TOURDD_BUS tdd = new TOURDD_BUS();
                CTNTQ_BUS ctntq = new CTNTQ_BUS();
                qlt.insert(tb1.Text, tb2.Text);
                int id = qlt.id();
                gt.insert(id, tb3.Value, dp1.Value, dp2.Value);
                Debug.WriteLine(tb3.Value+ " test");
                lt.insert(id,tb4.Text);
                
                int rowcount = this.dtgtt.Rows.Count;
                for (int i = 0; i < rowcount; i++)
                {
                    String dd = dtgtt.Rows[i].Cells[1].FormattedValue.ToString();
                    int iddd = ctntq.iddd(dd);
                    bool ok= tdd.insert(id, iddd);
                    Debug.WriteLine(id+" "+iddd);
                    Debug.WriteLine(ok);
                }
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            
        }
    }
}
