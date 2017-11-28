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
    public class CTNTQ_BUS
    {
        IRepository<CTNTQ> ctntq;
        public CTNTQ_BUS()
        {
            ctntq = new Repository<CTNTQ>();
        }
        public List<CTNTQ> GetAll()
        {
            return ctntq.GetAll();
        }
        public bool insert(CTNTQ t)
        {
            return ctntq.Insert(t);
        }
        public bool edit(CTNTQ t)
        {
            return ctntq.Update(t);
        }
        public List<CTNTQ> search(CTNTQ t)
        {
            return ctntq.Search(t);
        }
        
        public List<String> auto(String tg)
        {
            List<CTNTQ> lctntq = ctntq.GetAll();
            List<String> lauto = new List<String>();
            foreach (CTNTQ ct in lctntq)
            {
                if(ct.NOITHAMQUAN.TENGOI.Equals(tg))
                {
                    lauto.Add(ct.TENGOI);
                }               
                //Debug.WriteLine(ct.TENGOI);
            }
            return lauto;
        }
        public int iddd(String name)
        {
            TOURDD ct = new TOURDD();
            List<CTNTQ> lct = new List<CTNTQ>();
            lct = ctntq.GetAll();
            foreach (CTNTQ t in lct)
            {
                if (t.TENGOI.Equals(name))
                {
                    return t.ID;
                }
            }
            return -1;
        }

    }
}
