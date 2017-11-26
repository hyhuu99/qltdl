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
    public class NOITHAMQUAN_BUS
    {
        IRepository<NOITHAMQUAN> ntq;
        public NOITHAMQUAN_BUS()
        {
            ntq = new Repository<NOITHAMQUAN>();
        }
        public List<NOITHAMQUAN> GetAll()
        {
            return ntq.GetAll();
        }
        public bool insert(NOITHAMQUAN t)
        {
            return ntq.Insert(t);
        }
        public bool edit(NOITHAMQUAN t)
        {
            return ntq.Update(t);
        }
        public List<NOITHAMQUAN> search(NOITHAMQUAN t)
        {
            return ntq.Search(t);
        }
        public List<String> auto()
        {
            List<NOITHAMQUAN> lntq = ntq.GetAll();
            List<String> lauto= new List<String>();
            foreach(NOITHAMQUAN ntq in lntq)
            {
                lauto.Add(ntq.TENGOI);
                //Debug.WriteLine(ntq.TENGOI);
            }
            return lauto;
        }
    }
}
