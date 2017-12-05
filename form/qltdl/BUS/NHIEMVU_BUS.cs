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
    public class NHIEMVU_BUS
    {
        IRepository<NHIEMVU> nvu;
        public NHIEMVU_BUS()
        {
            nvu = new Repository<NHIEMVU>();
        }
        public bool insert(NHIEMVU nv)
        {
            return nvu.Insert(nv);
        }
        public List<NHIEMVU> getall()
        {
            return nvu.GetAll();
        }
        public NHIEMVU getbyid(int? id)
        {
            return nvu.GetById(id);
        }
        public bool update(NHIEMVU nv)
        {
            return nvu.Update(nv);
        }

    }
}
