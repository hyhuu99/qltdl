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
    public class LOAITOUR_BUS
    {
        IRepository<LOAITOUR> lt;
        public LOAITOUR_BUS()
        {
            lt = new Repository<LOAITOUR>();
        }
        public List<LOAITOUR> GetAll()
        {
            return lt.GetAll();
        }
        public bool insert(int idt,String ten)
        {
            LOAITOUR ltt = new LOAITOUR();
            ltt.IDT = idt;
            ltt.TENLOAI = ten;
            return lt.Insert(ltt);
        }
        public bool edit(LOAITOUR t)
        {
            return lt.Update(t);
        }
        public List<LOAITOUR> search(LOAITOUR t)
        {
            return lt.Search(t);
        }
        public List<String> auto()
        {
            List<LOAITOUR> lntq = lt.GetAll();
            List<String> lauto= new List<String>();
            foreach(LOAITOUR ntq in lntq)
            {
                lauto.Add(ntq.TENLOAI);
                //Debug.WriteLine(ntq.TENGOI);
            }
            return lauto;
        }
        public LOAITOUR search(int id)
        {
            return lt.GetAll().FirstOrDefault(c => c.IDT == id);
        }
    }
}
