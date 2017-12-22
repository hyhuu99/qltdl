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
            if (exist_nv(nv))
                return nvtd.Insert(nv);
            else
                return false;
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
        public bool exist_nv(NVTD nv)
        {
            NVTD nvtds= nvtd.GetAll().FirstOrDefault(c => c.IDNV==nv.IDNV && c.IDDDL==nv.IDDDL && c.IDNVU==nv.IDNVU);
            if (nvtds == null)
                return true;
            return false;
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
        public tknhanvien nvtheotour(int manv,DateTime bd,DateTime kt)
        {
            List<nvmodel> nvmd= nvtd.tknhanvien(manv, bd, kt);
            tknhanvien tk = new tknhanvien();
            tk.nhanvien = nvmd;
            return tk;
        }
        public tknhanvien khoitao()
        {
            tknhanvien tk = new tknhanvien();
            List<nvmodel> lnvmd = new List<nvmodel>();
            nvmodel nvmd = new nvmodel();
            List<NHANVIEN> lnv = nvb.GetAll();
            foreach(NHANVIEN nv in lnv)
            {
                nvmd.Ten = nv.TENNV;
                lnvmd.Add(nvmd);
            }
            tk.nhanvien = lnvmd;
            return tk;
        }
    }
}
