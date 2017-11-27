using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

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
        public bool insert(String ten,String dd)
        {
            TOUR t = new TOUR();
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
    
  
    }
}
