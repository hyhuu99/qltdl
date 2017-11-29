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
    public class NVNV_BUS
    {
        IRepository<NVNV> nvnv;
        public NVNV_BUS()
        {
            nvnv = new Repository<NVNV>();
        }
       
    }
}
