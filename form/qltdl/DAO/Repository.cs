using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft;
using System.Linq.Expressions;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore.Internal;

namespace DAO
{   
    public class Repository<T> : IRepository<T> where T : class
    {
        private QLTDLEntities db= new QLTDLEntities();
        private static string error_message = "";

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int? id)
        {
            return db.Set<T>().Find(id);
        }

        public bool Insert(T obj)
        {
            bool ok = false;
            try
            {

                db.Entry(obj).State = EntityState.Added;
                db.SaveChanges();
                ok = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }

            return ok;
        }

        public bool Delete(T obj)
        {
            bool ok = false;

            try
            {
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                ok = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return ok;
        }

        public bool Update(T obj)
        {
            bool ok = false;
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.SaveChanges();
                    ok = true;
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                }
            }
            return ok;
        }

        public bool Exists(T obj)
        {
            return db.Set<T>().Any();
        }

        public List<T> Search(Expression<Func<T, bool>> where)
        {    
            
            return db.Set<T>().Where(where).ToList();
        }
        public List<nvmodel> tknhanvien(int manv,DateTime bd,DateTime kt)
        {           
            List<nvmodel> lnvm = new List<nvmodel>();
            List<NHANVIEN> lnv = new List<NHANVIEN>();
            lnv = db.NHANVIENs.Where(o => o.ID == manv).ToList();
            List<NVTD> lnvtd = db.NVTDs.Where(o => o.IDNV == manv && o.DOANDL.NGAYBD >= bd && o.DOANDL.NGAYKT <= kt)
                                       .ToList();
            //lnvtd = lnvtd.GroupBy(o => o.IDDDL).Select(g => g.First()).ToList();
            //List<int> count = new List<int>();
            //foreach (NVTD nvtd in lnvtd)
            //{
            //    //Select(o => new { o.IDDDL, o.IDNV, o.IDNVU })
            //    int x = db.NVTDs.Where(o => o.IDNV == manv && o.DOANDL.TOUR.ID==nvtd.DOANDL.TOUR.ID)
            //      .Select(o => o.DOANDL.TOUR.ID).Count();
            //    count.Add(x);
            //}
            lnvtd = lnvtd.GroupBy(o => o.DOANDL.TOUR.ID).Select(g => g.First()).ToList();
            foreach (NVTD nvtd in lnvtd)
            {

                nvmodel nvm = new nvmodel();
                nvm.Tentour = nvtd.DOANDL.TOUR.TENGOI;               
                nvm.Ten = nvtd.NHANVIEN.TENNV;
                nvm.Sl = db.NVTDs.Where(o => o.IDNV == manv && o.DOANDL.TOUR.ID == nvtd.DOANDL.TOUR.ID)
                  //.GroupBy(o => o.DOANDL.TOUR.ID)
                  .Select(o => o.DOANDL.ID)
                  .Distinct()
                  .Count();
                lnvm.Add(nvm);
            }

            return lnvm;
        }
        public List<T> Search(T obj)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
