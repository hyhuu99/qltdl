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
        IRepository<NHANVIEN> nv;
        public NHANVIEN_BUS()
        {
            nv = new Repository<NHANVIEN>();
        }
       
    }
}
