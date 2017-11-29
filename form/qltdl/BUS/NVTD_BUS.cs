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
    public class NVTD_BUS
    {
        IRepository<NVTD> nvtd;
        public NVTD_BUS()
        {
            nvtd = new Repository<NVTD>();
        }
       
    }
}
