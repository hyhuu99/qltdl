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
    public class DOANDL_BUS
    {
        IRepository<DOANDL> doandl;
        public DOANDL_BUS()
        {
            doandl = new Repository<DOANDL>();
        }
        public int testing_bus()
        {
            int testing =20;
        }
       
    }
}
