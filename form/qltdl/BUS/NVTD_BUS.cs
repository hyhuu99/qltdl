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
        IRepository<DOANDL> ddlb;
        IRepository<NHIEMVU> nvub;
        IRepository<NHANVIEN> nvb;
        public NVTD_BUS()
        {
            nvtd = new Repository<NVTD>();
            ddlb = new Repository<DOANDL>();
            nvub = new Repository<NHIEMVU>();
            nvb = new Repository<NHANVIEN>();
        }
        public bool insert(NVTD nv)
        {
            return nvtd.Insert(nv);
        }
        public List<NVTD> getall()
        {
            return nvtd.GetAll();
        }
        public NVTD getbyid(int? id)
        {
            return nvtd.GetById(id);
        }
        public bool update(NVTD nv)
        {
            return nvtd.Update(nv);
        }
        public List<DOANDL> getddl()
        {
            return ddlb.GetAll();
        }
        public List<NHANVIEN> getnv()
        {
            List<NHANVIEN> lnv = nvb.GetAll();
            foreach(NHANVIEN nv in lnv)
            {
                nv.TENNV = nv.TENNV +" "+ nv.CMND;
            }
            return lnv;
        }
        public List<NHIEMVU> getnvu()
        {
            return nvub.GetAll();
        }
    }
}
