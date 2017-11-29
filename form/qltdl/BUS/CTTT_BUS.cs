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
    public class CTTT_BUS
    {
        IRepository<CTTT> cttt;
        public CTTT_BUS()
        {
            cttt = new Repository<CTTT>();
        }
       

    }
}
