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
    public class NHANVIENsController : Controller
    {
        private NHANVIEN_BUS nvb = new NHANVIEN_BUS();
        // GET: NHANVIENs
        public ActionResult Index()
        {
            return View(nvb.getall().ToList());
        }

        // GET: NHANVIENs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = nvb.getbyid(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Create
        public ActionResult Create()
        {
            List<String> genderList = new List<String>();
            genderList.Add("Nam");
            genderList.Add("Nữ");
            ViewBag.Gioitinh = new SelectList(genderList);
            ViewBag.IDNV= new SelectList(nvb.getall(), "ID", "TENNV");
            return View();
        }

        // POST: NHANVIENs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TENNV,HOTL,SDT,GIOITINH,CMND")] NHANVIEN nv)
        {
           
            if (ModelState.IsValid)
            {
                nvb.insert(nv);
                return RedirectToAction("Index");
            }

            return View(nv);
        }

        // GET: NHANVIENs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = nvb.getbyid(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TENNV,HOTL,SDT,GIOITINH,CMND")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                nvb.update(nHANVIEN);
                return RedirectToAction("Index");
            }
            return View(nHANVIEN);
        }



        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        nvb.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
