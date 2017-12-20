using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DTO;
using BUS;

namespace qltdl_web.Controllers
{
    public class CTTTsController : Controller
    {

        private CTTT_BUS ctb = new CTTT_BUS();
        // GET: CTTTs
        public ActionResult Index()
        {
            //var cTTTs = db.CTTTs.Include(c => c.DOANDL).Include(c => c.LOAITT);
            return View(ctb.getall());
        }

        // GET: CTTTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTTT cTTT = ctb.getbyid(id);
            if (cTTT == null)
            {
                return HttpNotFound();
            }
            return View(cTTT);
        }

        // GET: CTTTs/Create
        public ActionResult Create()
        {
            ViewBag.IDDDL = new SelectList(ctb.getallddl(), "ID", "TENGOI");
            ViewBag.IDLOAI = new SelectList(ctb.getalltt(), "ID", "NOIDUNG");
            return View();
        }

        // POST: CTTTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDDDL,IDLOAI,NOIDUNG,THANHTIEN")] CTTT cTTT)
        {
            if (ModelState.IsValid)
            {
                ctb.insert(cTTT);
    
                return RedirectToAction("Index");
            }

            ViewBag.IDDDL = new SelectList(ctb.getallddl(), "ID", "TENGOI", cTTT.IDDDL);
            ViewBag.IDLOAI = new SelectList(ctb.getalltt(), "ID", "NOIDUNG", cTTT.IDLOAI);
            return View(cTTT);
        }

        // GET: CTTTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTTT cTTT = ctb.getbyid(id);
            if (cTTT == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDDDL = new SelectList(ctb.getallddl(), "ID", "TENGOI", cTTT.IDDDL);
            ViewBag.IDLOAI = new SelectList(ctb.getalltt(), "ID", "NOIDUNG", cTTT.IDLOAI);
            return View(cTTT);
        }

        // POST: CTTTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDDDL,IDLOAI,NOIDUNG,THANHTIEN")] CTTT cTTT)
        {
            if (ModelState.IsValid)
            {
                ctb.update(cTTT);
                return RedirectToAction("Index");
            }
            ViewBag.IDDDL = new SelectList(ctb.getallddl(), "ID", "TENGOI", cTTT.IDDDL);
            ViewBag.IDLOAI = new SelectList(ctb.getalltt(), "ID", "NOIDUNG", cTTT.IDLOAI);
            return View(cTTT);
        }


       
    }
}
