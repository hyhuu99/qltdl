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
        IRepository<TOUR> tour;
        IRepository<KH> kh;
        IRepository<NHANVIEN> nv;
        public DOANDL_BUS()
        {
            doandl = new Repository<DOANDL>();
            tour = new Repository<TOUR>();
        }
        public List<DOANDL> getall()
        {
            return doandl.GetAll();
        }
        public List<TOUR> getalltour()
        {
            return tour.GetAll();
        }
        public bool insertddl(DOANDL dl)
        {
            dl.TONGKINHPHI = 0;
            return doandl.Insert(dl);
        }
        public DOANDL searchddl(int? id)
        {
            return doandl.GetById(id);
        }
        public bool updateddl(DOANDL dl)
        {
            return doandl.Update(dl);
        }
       
    }
}
