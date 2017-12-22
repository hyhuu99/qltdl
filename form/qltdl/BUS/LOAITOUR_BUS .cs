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
        //public bool insert(int idt,String ten)
        //{
        //    LOAITOUR ltt = new LOAITOUR();
        //    ltt.TENLOAI = ten;
        //    return lt.Insert(ltt);
        //}
        public List<String> auto()
        {
            List<LOAITOUR> ltt = lt.GetAll();
            List<String> lauto= new List<String>();
            foreach(LOAITOUR lts in ltt)
            {
                lauto.Add(lts.TENLOAI);
                //Debug.WriteLine(ntq.TENGOI);
            }
            return lauto;
        }
        //public LOAITOUR search(int id)
        //{
        //    return lt.GetAll().FirstOrDefault(c => c.IDT == id);
        //}
        //public bool update(int idt, String ten)
        //{
        //    LOAITOUR ltt = new LOAITOUR();
        //    ltt.ID = search(idt).ID;
        //    ltt.IDT = idt;
        //    ltt.TENLOAI = ten;
        //    return lt.Update(ltt);
        //}
        public int idloai(String name)
        {
            TOURDD ct = new TOURDD();
            List<LOAITOUR> llt = new List<LOAITOUR>();
            llt = lt.GetAll();
            foreach (LOAITOUR lt in llt)
            {
                if (lt.TENLOAI.Equals(name))
                {
                    return lt.ID;
                }
            }
            return -1;
        }

    }
}
