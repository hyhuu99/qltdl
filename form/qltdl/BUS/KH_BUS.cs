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
        IRepository<KH> kh;
        public KH_BUS()
        {
            kh = new Repository<KH>();
        }
       
    }
}
