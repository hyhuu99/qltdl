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
    public class NVTDsController : Controller
    {
        private NVTD_BUS nvtdb = new NVTD_BUS();
        // GET: NVTDs
        public ActionResult Index()
        {
            //var nVTDs = db.NVTDs.Include(n => n.DOANDL).Include(n => n.NHANVIEN).Include(n => n.NHIEMVU);
            return View(nvtdb.getall());
        }

        // GET: NVTDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVTD nVTD = nvtdb.getbyid(id);
            if (nVTD == null)
            {
                return HttpNotFound();
            }
            return View(nVTD);
        }

        // GET: NVTDs/Create
        public ActionResult Create()
        {
            ViewBag.IDDDL = new SelectList(nvtdb.getddl(), "ID", "TENGOI");
            ViewBag.IDNV = new SelectList(nvtdb.getnv(), "ID", "TENNV");
            ViewBag.IDNVU = new SelectList(nvtdb.getnvu(), "ID", "NHIEMVU1");
            return View();
        }

        // POST: NVTDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDDDL,IDNVU,IDNV,CMND")] NVTD nVTD)
        {
            if (ModelState.IsValid)
            {
                nvtdb.insert(nVTD);
                return RedirectToAction("Index");
            }

            ViewBag.IDDDL = new SelectList(nvtdb.getddl(), "ID", "TENGOI", nVTD.IDDDL);
            ViewBag.IDNV = new SelectList(nvtdb.getnv(), "ID", "TENNV", nVTD.IDNV);
            ViewBag.IDNVU = new SelectList(nvtdb.getnvu(), "ID", "NHIEMVU1", nVTD.IDNVU);
            return View(nVTD);
        }

        // GET: NVTDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVTD nVTD = nvtdb.getbyid(id);
            if (nVTD == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDDDL = new SelectList(nvtdb.getddl(), "ID", "TENGOI", nVTD.IDDDL);
            ViewBag.IDNV = new SelectList(nvtdb.getnv(), "ID", "TENNV", nVTD.IDNV);
            ViewBag.IDNVU = new SelectList(nvtdb.getnvu(), "ID", "NHIEMVU1", nVTD.IDNVU);
            return View(nVTD);
        }

        // POST: NVTDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDDDL,IDNVU,IDNV,CMND")] NVTD nVTD)
        {
            if (ModelState.IsValid)
            {
                nvtdb.update(nVTD);
                return RedirectToAction("Index");
            }
            ViewBag.IDDDL = new SelectList(nvtdb.getddl(), "ID", "TENGOI", nVTD.IDDDL);
            ViewBag.IDNV = new SelectList(nvtdb.getnv(), "ID", "TENNV", nVTD.IDNV);
            ViewBag.IDNVU = new SelectList(nvtdb.getnvu(), "ID", "NHIEMVU1", nVTD.IDNVU);
            return View(nVTD);
        }



   
    }
}
