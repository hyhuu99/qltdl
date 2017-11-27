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
        IRepository<LOAITOUR> ntq;
        public LOAITOUR_BUS()
        {
            ntq = new Repository<LOAITOUR>();
        }
        public List<LOAITOUR> GetAll()
        {
            return ntq.GetAll();
        }
        public bool insert(String ten)
        {
            LOAITOUR lt = new LOAITOUR();
            lt.TENLOAI = ten;
            return ntq.Insert(lt);
        }
        public bool edit(LOAITOUR t)
        {
            return ntq.Update(t);
        }
        public List<LOAITOUR> search(LOAITOUR t)
        {
            return ntq.Search(t);
        }
        public List<String> auto()
        {
            List<LOAITOUR> lntq = ntq.GetAll();
            List<String> lauto= new List<String>();
            foreach(LOAITOUR ntq in lntq)
            {
                lauto.Add(ntq.TENLOAI);
                //Debug.WriteLine(ntq.TENGOI);
            }
            return lauto;
        }
    }
}
