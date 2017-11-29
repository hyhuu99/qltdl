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
    public class LOAITT_BUS
    {
        IRepository<LOAITT> loaitt;
        public LOAITT_BUS()
        {
            loaitt = new Repository<LOAITT>();
        }
       
    }
}
