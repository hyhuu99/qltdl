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
        DOANDL_BUS ddb = new DOANDL_BUS();
        IRepository<KH> khb;
        GIATOUR_BUS gtb = new GIATOUR_BUS();
        public TGTOUR_BUS()
        {
            tgtour = new Repository<TGTOUR>();
            khb = new Repository<KH>();
        }
        public bool insert(TGTOUR tgt)
        {
            DOANDL ddl = ddb.searchddl(tgt.IDDDL);
            ddl.TONGKINHPHI += gtb.search(ddl.IDT).GIATOUR1;
            ddb.updateddl(ddl);
            return tgtour.Insert(tgt);
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
            return ddb.getall();
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
            DOANDL ddl = ddb.searchddl(tgt.IDDDL);
            ddl.TONGKINHPHI -= gtb.search(ddl.IDT).GIATOUR1;
            ddb.updateddl(ddl);
            return tgtour.Delete(tgt);
        }
    }
}
