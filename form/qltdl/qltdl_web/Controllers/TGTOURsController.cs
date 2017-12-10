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
    public class TGTOURsController : Controller
    {

        private TGTOUR_BUS tgtb = new TGTOUR_BUS();
        // GET: TGTOURs
        public ActionResult Index()
        {
            //var tGTOURs = db.TGTOURs.Include(t => t.DOANDL).Include(t => t.KH);
            return View(tgtb.getall());
        }

        // GET: TGTOURs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TGTOUR tGTOUR = tgtb.getbyid(id);
            if (tGTOUR == null)
            {
                return HttpNotFound();
            }
            return View(tGTOUR);
        }

        // GET: TGTOURs/Create
        public ActionResult Create()
        {
            ViewBag.IDDDL = new SelectList(tgtb.getallddl(), "ID", "TENGOI");
            ViewBag.IDKH = new SelectList(tgtb.getallkh(), "ID", "TEN");
            return View();
        }

        // POST: TGTOURs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDKH,IDDDL")] TGTOUR tGTOUR)
        {
            if (ModelState.IsValid)
            {
                tgtb.insert(tGTOUR);
                return RedirectToAction("Index");
            }

            ViewBag.IDDDL = new SelectList(tgtb.getallddl(), "ID", "TENGOI", tGTOUR.IDDDL);
            ViewBag.IDKH = new SelectList(tgtb.getallkh(), "ID", "TEN", tGTOUR.IDKH);
            return View(tGTOUR);
        }

        // GET: TGTOURs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TGTOUR tGTOUR = tgtb.getbyid(id);
            if (tGTOUR == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDDDL = new SelectList(tgtb.getallddl(), "ID", "TENGOI", tGTOUR.IDDDL);
            ViewBag.IDKH = new SelectList(tgtb.getallkh(), "ID", "TEN", tGTOUR.IDKH);
            return View(tGTOUR);
        }

        // POST: TGTOURs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDKH,IDDDL")] TGTOUR tGTOUR)
        {
            if (ModelState.IsValid)
            {
                tgtb.update(tGTOUR);
                return RedirectToAction("Index");
            }
            ViewBag.IDDDL = new SelectList(tgtb.getallddl(), "ID", "TENGOI", tGTOUR.IDDDL);
            ViewBag.IDKH = new SelectList(tgtb.getallkh(), "ID", "TÊN", tGTOUR.IDKH);
            return View(tGTOUR);
        }

        // GET: TGTOURs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TGTOUR tGTOUR = tgtb.getbyid(id);
            if (tGTOUR == null)
            {
                return HttpNotFound();
            }
            return View(tGTOUR);
        }

        // POST: TGTOURs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {        
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TGTOUR tGTOUR = tgtb.getbyid(id);
            tgtb.delete(tGTOUR);
            return RedirectToAction("Index");
        }
    }
}
