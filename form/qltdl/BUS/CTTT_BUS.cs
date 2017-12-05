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
