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
    public class DOANDLsController : Controller
    {
        private DOANDL_BUS ddl = new DOANDL_BUS();
        // GET: DOANDLs
        public ActionResult Index()
        {
            return View(ddl.getall().ToList());
        }

        // GET: DOANDLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOANDL dOANDL = ddl.searchddl(id);
            if (dOANDL == null)
            {
                return HttpNotFound();
            }
            return View(dOANDL);
        }

        // GET: DOANDLs/Create
        public ActionResult Create()
        {
            ViewBag.IDT = new SelectList(ddl.getalltour(),"ID","TENGOI");
            return View();
        }

        // POST: DOANDLs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDT,TENGOI,NGAYBD,NGAYKT,TONGKINHPHI")] DOANDL doandl)
        {
            if (ModelState.IsValid)
            {
                bool ok= ddl.insertddl(doandl);
                if(ok==true)
                return RedirectToAction("Index");
                else
                {
                    ModelState.AddModelError("", "Số lượng đã bị lỗi");
                    return View(doandl);
                }
                    
            }

            return View(doandl);
        }

        // GET: DOANDLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOANDL dOANDL = ddl.searchddl(id);
            if (dOANDL == null)
            {
                return HttpNotFound();
            }
            return View(dOANDL);
        }

        // POST: DOANDLs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDT,TENGOI,NGAYBD,NGAYKT")] DOANDL doandl)
        {
            if (ModelState.IsValid)
            {
                ddl.updateddl(doandl);
                return RedirectToAction("Index");
            }
            return View(doandl);
        }

        //// GET: DOANDLs/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DOANDL dOANDL = db.DOANDLs.Find(id);
        //    if (dOANDL == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(dOANDL);
        //}

        //// POST: DOANDLs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    DOANDL dOANDL = db.DOANDLs.Find(id);
        //    db.DOANDLs.Remove(dOANDL);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

       
    }
}
