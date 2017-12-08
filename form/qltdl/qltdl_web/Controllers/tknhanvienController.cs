using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BUS;

namespace qltdl_web.Controllers
{
    public class tknhanvienController : Controller
    {
        private NVTD_BUS nvtdb = new NVTD_BUS();
        // GET: tknhanvien
        public ActionResult Index(int? IDNV, string ngaybt, string ngaykt)
        {
            ViewBag.IDNV = new SelectList(nvtdb.getnv(), "ID", "TENNV");
            tknhanvien tknv = new tknhanvien();
            DateTime start;
            DateTime end;
            if(IDNV!=null)
            {
                int id = IDNV.GetValueOrDefault();
                if (DateTime.TryParse(ngaybt, out start) && DateTime.TryParse(ngaykt, out end))
                {
                    tknv = nvtdb.nvtheotour(id, start, end);             
                    return View(tknv);
                }
            }
            tknv = nvtdb.khoitao();
            return View(tknv);
        }
    }
}