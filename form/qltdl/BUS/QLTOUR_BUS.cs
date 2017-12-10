using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using viewmodel;

namespace BUS
{
    public class QLTOUR_BUS
    {
        IRepository<TOUR> qltour;
        IRepository<CTNTQ_BUS> ctntq;
        public QLTOUR_BUS()
        {
            qltour = new Repository<TOUR>();
            ctntq = new Repository<CTNTQ_BUS>();
        }
        public List<TOUR> GetAll()
        {
            return qltour.GetAll();
        }
        public bool insert(String ten,String dd,int idl)
        {
            TOUR t = new TOUR();
            t.IDL = idl;
            t.TENGOI = ten;
            t.DACDIEM = dd;
            return qltour.Insert(t);
        }
        public bool edit(TOUR t)
        {
            return qltour.Update(t);
        }
        public List<TOUR> search(TOUR t)
        {           
            return qltour.Search(t);
        }
        public int id()
        {
            return qltour.GetAll().Max(c => c.ID);
        }
        public List<tourview> load()
        {
            List<TOUR> lt = qltour.GetAll();
            GIATOUR_BUS gt = new GIATOUR_BUS();
            LOAITOUR_BUS ltt = new LOAITOUR_BUS();
            TOURDD_BUS tdd = new TOURDD_BUS();
            List<tourview> ltv = new List<tourview>();
            foreach(TOUR t in lt)
            {
                tourview tv = new tourview();
                GIATOUR gtt = gt.search(t.ID);
                tv.loai = t.LOAITOUR.TENLOAI;
                tv.tengoi = t.TENGOI;
                tv.dacdiem = t.DACDIEM;
                tv.giatour = gtt.GIATOUR1;
                tv.ngaybd = gtt.NGAYBD;
                tv.ngaykt = gtt.NGAYKT;
                tv.id = t.ID;
                ltv.Add(tv);
            }
            return ltv;
            
        }
        public bool update(int id,String ten, String dd,int idl)
        {
            TOUR t = new TOUR();
            t.ID = id;
            t.TENGOI = ten;
            t.DACDIEM = dd;
            t.IDL = idl;
            return qltour.Update(t);
        }
        public List<String> auto()
        {
            List<TOUR> lt = qltour.GetAll();
            List<String> result = new List<String>();
            foreach (TOUR t in lt)
            {
                result.Add(t.TENGOI);
                //Debug.WriteLine(ntq.TENGOI);
            }
            return result;
        }
        public List<tktour> thongketour(String tentour)
        {
            List<tktour> ltkt = new List<tktour>();
            TOUR t = new TOUR();
            List<TOUR> lt = qltour.GetAll();
            foreach (TOUR temp in lt)
            {
                if (temp.TENGOI.Equals(tentour))
                {
                    t = temp;break;
                }
            }
            List<DOANDL> ldlt=t.DOANDLs.Where(o => o.NGAYKT < DateTime.Now).ToList();
            foreach(DOANDL temp in  ldlt)
            {
                tktour tkt = new tktour();
                tkt.Tentour = temp.TOUR.TENGOI;
                tkt.Tenddl = temp.TENGOI;
                List<CTTT> lctt = temp.CTTTs.ToList();
                tkt.Tienloi = temp.TONGKINHPHI.GetValueOrDefault() - loinhuan(lctt);
                ltkt.Add(tkt);
            }
            return ltkt;
        }
        private decimal loinhuan(List<CTTT> lctt)
        {
            decimal? loinhuan = 0;
            foreach(CTTT ctt in lctt)
            {
                loinhuan += ctt.THANHTIEN;
            }
            return loinhuan.GetValueOrDefault();
        }
    
  
    }
}
