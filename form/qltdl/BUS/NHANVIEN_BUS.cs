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
    public class NHANVIEN_BUS
    {
        IRepository<NHANVIEN> nvb;
        //IRepository<NVNV> nvnv;
        public NHANVIEN_BUS()
        {
            nvb = new Repository<NHANVIEN>();
           // nvnv = new Repository<NVNV>();
        }
        public NHANVIEN getbyid(int? id)
        {
            return nvb.GetById(id);
        }
        public bool insert(NHANVIEN nv)
        {
            return nvb.Insert(nv);
        }
        public bool update(NHANVIEN nv)
        {
            return nvb.Update(nv);
        }
        public List<NHANVIEN> getall()
        {
            return nvb.GetAll();
        }
       

    }
}
