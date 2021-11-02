using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyHangHoa.Models;
using QuanLyHangHoa.Models.Process;

namespace QuanLyHangHoa.Controllers
{
    public class HangHoasController : Controller
    {
        private QLHHDbcontext db = new QLHHDbcontext();
        private StringProcess strPro = new StringProcess();
        // GET: HangHoas
        public ActionResult Index()
        {
            return View(db.Hanghoas.ToList());
        }

        // GET: HangHoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HangHoa hangHoa = db.Hanghoas.Find(id);
            if (hangHoa == null)
            {
                return HttpNotFound();
            }
            return View(hangHoa);
        }

        // GET: HangHoas/Create
        public ActionResult Create()
        {
            string HangHoaKey = "";
            var maHH = db.Hanghoas.ToList();
            if (maHH.Count==0)
            {
                HangHoaKey = "MH001";
            }
            else
            {
                var MaHH = maHH.OrderByDescending(m => m.MaHH).FirstOrDefault().MaHH;
                HangHoaKey = strPro.AutoGenerateKey(MaHH);
            }
            ViewBag.MH = HangHoaKey;
            return View();
        }

        // POST: HangHoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHH,TenHH")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                db.Hanghoas.Add(hangHoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hangHoa);
        }

        // GET: HangHoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HangHoa hangHoa = db.Hanghoas.Find(id);
            if (hangHoa == null)
            {
                return HttpNotFound();
            }
            return View(hangHoa);
        }

        // POST: HangHoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHH,TenHH")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hangHoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hangHoa);
        }

        // GET: HangHoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HangHoa hangHoa = db.Hanghoas.Find(id);
            if (hangHoa == null)
            {
                return HttpNotFound();
            }
            return View(hangHoa);
        }

        // POST: HangHoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HangHoa hangHoa = db.Hanghoas.Find(id);
            db.Hanghoas.Remove(hangHoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
