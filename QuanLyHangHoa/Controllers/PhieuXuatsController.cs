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
    public class PhieuXuatsController : Controller
    {
        private QLHHDbcontext db = new QLHHDbcontext();
        private StringProcess strPro = new StringProcess();

        // GET: PhieuXuats
        public ActionResult Index()
        {
            return View(db.PhieuXuats.ToList());
        }

        // GET: PhieuXuats/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            if (phieuXuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuat);
        }

        // GET: PhieuXuats/Create
        public ActionResult Create()
        {
            string PhieuXuatKey = "";
            var model = db.PhieuXuats.ToList();
            if (model.Count == 0)
            {
                PhieuXuatKey = "MPX001";
            }
            else
            {
                var MaPX = model.OrderByDescending(m => m.MaPX).FirstOrDefault().MaPX;
                PhieuXuatKey = strPro.AutoGenerateKey(MaPX);
            }
            ViewBag.MaPX = PhieuXuatKey;
            return View();
        }

        // POST: PhieuXuats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPX,MaSP,SoLuongXuat,DonGia,ThanhTien,MaNCC,NgayTaoPhieu")] PhieuXuat phieuXuat)
        {
            if (ModelState.IsValid)
            {
                db.PhieuXuats.Add(phieuXuat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phieuXuat);
        }

        // GET: PhieuXuats/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            if (phieuXuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuat);
        }

        // POST: PhieuXuats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPX,MaSP,SoLuongXuat,DonGia,ThanhTien,MaNCC,NgayTaoPhieu")] PhieuXuat phieuXuat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuXuat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phieuXuat);
        }

        // GET: PhieuXuats/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            if (phieuXuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuat);
        }

        // POST: PhieuXuats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            db.PhieuXuats.Remove(phieuXuat);
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
