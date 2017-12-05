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
    public class KH_BUS
    {
        IRepository<KH> khs;
        public KH_BUS()
        {
            khs = new Repository<KH>();
        }
        public bool insert (KH kh)
        {
            return khs.Insert(kh);
        }
        public List<KH> getall()
        {
            return khs.GetAll();
        }
        public KH getbyid(int? id)
        {
            return khs.GetById(id);
        }
        public bool update(KH kh)
        {
            return khs.Update(kh);
        }
       
    }
}
