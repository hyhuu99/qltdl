using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class GIATOUR_BUS
    {
        IRepository<GIATOUR> gt;
        public GIATOUR_BUS()
        {
            gt = new Repository<GIATOUR>();
        }
        public List<GIATOUR> GetAll()
        {
            return gt.GetAll();
        }
        public bool insert(int idt,decimal gia,DateTime ngaybd,DateTime ngaykt)
        {
            GIATOUR gtt = new GIATOUR();
            gtt.IDT = idt;
            gtt.GIATOUR1 = gia;
            gtt.NGAYBD = ngaybd;
            gtt.NGAYKT = ngaykt;
            return gt.Insert(gtt);
        }
        public bool edit(GIATOUR t)
        {
            return gt.Update(t);
        }
        public List<GIATOUR> search(GIATOUR t)
        {           
            return gt.Search(t);
        }
    
  
    }
}
