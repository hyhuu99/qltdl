using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Diagnostics;

namespace BUS
{
    public class CTTT_BUS
    {
        IRepository<CTTT> cttt;
        IRepository<DOANDL> ddlb;
        IRepository<LOAITT> loaittb;
        public CTTT_BUS()
        {
            cttt = new Repository<CTTT>();
            ddlb = new Repository<DOANDL>();
            loaittb = new Repository<LOAITT>();
        }
        public bool insert(CTTT nv)
        {
            return cttt.Insert(nv);
        }
        public List<CTTT> getall()
        {
            return cttt.GetAll();
        }
        public CTTT getbyid(int? id)
        {
            return cttt.GetById(id);
        }
        public List<tkchiphi> tkchiphi(DateTime ngaybd, DateTime ngaykt, int idt)
        {
            List<tkchiphi> ltkcp = new List<tkchiphi>();
            List<DOANDL> lddl= ddlb.GetAll().Where(c => c.IDT == idt && c.NGAYBD > ngaybd && c.NGAYKT < ngaykt).ToList();
            foreach(DOANDL ddl in lddl)
            {
                tkchiphi tk = new tkchiphi();
                tk.tendoandl = ddl.TENGOI;
                tk.tongkinhphi = ddl.TONGKINHPHI.GetValueOrDefault();
                tk.loinhuan = ddl.TONGKINHPHI.GetValueOrDefault() - tongtien(ddl);
                tk.iddl = ddl.ID;
                ltkcp.Add(tk);
            }
            return ltkcp;
        }
        private decimal tongtien(DOANDL ddl)
        {
            List<CTTT> lctt = cttt.GetAll().Where(c => c.IDDDL == ddl.ID).ToList();
            decimal tong = 0;
            foreach(CTTT ctt in lctt)
            {
                tong += ctt.THANHTIEN.GetValueOrDefault();
            }
            return tong;
        }
        public List<tkcttt> getlistcttt(int idddl)
        {
            List<tkcttt> ltkct = new List<tkcttt>();
            List<CTTT>lctt= cttt.GetAll().Where(c => c.IDDDL == idddl).ToList();
            foreach(CTTT cttt in lctt)
            {
                tkcttt tk = new tkcttt();
                tk.tendoandl = cttt.DOANDL.TENGOI;
                tk.tenloai = cttt.LOAITT.NOIDUNG;
                tk.noidung = cttt.NOIDUNG;
                tk.thanhtien = cttt.THANHTIEN.GetValueOrDefault();
                ltkct.Add(tk);
            }
            return ltkct;
        }
        public bool update(CTTT nv)
        {
            return cttt.Update(nv);
        }
        public List<DOANDL> getallddl()
        {
            return ddlb.GetAll();
        }
        public List<LOAITT> getalltt()
        {
            return loaittb.GetAll();
        }

    }
}
