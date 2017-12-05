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
    public class TGTOUR_BUS
    {
        IRepository<TGTOUR> tgtour;
        IRepository<DOANDL> ddlb;
        IRepository<KH> khb;
        public TGTOUR_BUS()
        {
            tgtour = new Repository<TGTOUR>();
            ddlb = new Repository<DOANDL>();
            khb = new Repository<KH>();
        }
        public bool insert(TGTOUR nv)
        {
            return tgtour.Insert(nv);
        }
        public List<TGTOUR> getall()
        {
            return tgtour.GetAll();
        }
        public TGTOUR getbyid(int? id)
        {
            return tgtour.GetById(id);
        }
        public bool update(TGTOUR tgt)
        {
            return tgtour.Update(tgt);
        }
        public List<DOANDL> getallddl()
        {
            return ddlb.GetAll();
        }
        public List<KH> getallkh()
        {
            List<KH> lkh = khb.GetAll();
            foreach (KH kh in lkh)
            {
                kh.TEN = kh.TEN+ " " + kh.CMND;
            }
            return lkh;
        }
        public bool delete(TGTOUR tgt)
        {
            return tgtour.Delete(tgt);
        }
    }
}
