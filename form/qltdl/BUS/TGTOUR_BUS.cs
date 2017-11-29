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
    public class TGTOUR_BUS
    {
        IRepository<TGTOUR> tgtour;
        public TGTOUR_BUS()
        {
            tgtour = new Repository<TGTOUR>();
        }
       
    }
}
