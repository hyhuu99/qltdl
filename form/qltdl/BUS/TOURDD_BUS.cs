using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TOURDD_BUS
    {
        IRepository<TOURDD> tourdd;
      
        public TOURDD_BUS()
        {
            tourdd = new Repository<TOURDD>();
                    }
        public List<TOURDD> GetAll()
        {
            return tourdd.GetAll();
        }
        public bool insert(int idt,int iddd)
        {
            TOURDD t = new TOURDD();
            t.IDT = idt;
            t.IDDD = iddd;
            return tourdd.Insert(t);
        }
        public bool edit(TOURDD t)
        {
            return tourdd.Update(t);
        }
        public List<TOURDD> search(TOURDD t)
        {           
            return tourdd.Search(t);
        }
        public int iddd(String name)
        {
            TOURDD ct = new TOURDD();
            List<TOURDD> lct = new List<TOURDD>();
            lct = tourdd.GetAll();
            foreach (TOURDD t in lct)
            {
                if (t.CTNTQ.Equals(name))
                {
                    return t.CTNTQ.ID;
                }
            }
            return -1;
        }
        public int id()
        {
            return tourdd.GetAll().Max(c => c.ID);
        }
    
  
    }
}
