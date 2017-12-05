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
using System.Collections;

namespace qltdl_web.Controllers
{
    public class KHsController : Controller
    {
        private QLTDLEntities db = new QLTDLEntities();
        private KH_BUS khb = new KH_BUS();
        // GET: KHs
        public ActionResult Index()
        {
            return View(khb.getall());
        }

        // GET: KHs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KH kH = khb.getbyid(id);
            if (kH == null)
            {
                return HttpNotFound();
            }
            return View(kH);
        }

        // GET: KHs/Create
        public ActionResult Create()
        {
            //List<IEnumerable> gt = new List<IEnumerable>();
            //gt.Add("Nam");
            //gt.Add("Nữ");
            //ViewBag.Gioitinh = gt.ToList();
            List<String> genderList = new List<String>();
            genderList.Add("Nam");
            genderList.Add("Nữ");
            ViewBag.Gioitinh = new SelectList(genderList, "String");
            return View();
        }

        // POST: KHs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,HOTL,TEN,CMND,GIOITINH,DIACHI,SDT,QUOCTICH")] KH kH)
        {
            if (ModelState.IsValid)
            {
                khb.insert(kH);
                return RedirectToAction("Index");
            }

            return View(kH);
        }

        // GET: KHs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KH kH = khb.getbyid(id);
            if (kH == null)
            {
                return HttpNotFound();
            }
            return View(kH);
        }

        // POST: KHs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,HOTL,TEN,CMND,GIOITINH,DIACHI,SDT,QUOCTICH")] KH kH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kH);
        }

        // GET: KHs/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    KH kH = db.KHs.Find(id);
        //    if (kH == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(kH);
        //}

        //// POST: KHs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    KH kH = db.KHs.Find(id);
        //    db.KHs.Remove(kH);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
