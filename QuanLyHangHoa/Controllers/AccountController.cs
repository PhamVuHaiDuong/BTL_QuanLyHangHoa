using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using QuanLyHangHoa.Models;

namespace QuanLyHangHoa.Controllers
{
    public class AccountController : Controller
    {
        Encrytion Encry = new Encrytion();
        QLHHDbcontext db = new QLHHDbcontext();
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public ActionResult Register(Account acc)
        {
            if(ModelState.IsValid)
            {
                acc.Password = Encry.PasswordEncrytion(acc.Password);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login","Account");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                //ma hoa password gui len tu client
                string encrytionpass = Encry.PasswordEncrytion(acc.Password);
                var model = db.Accounts.Where(m => m.Username == acc.Username && m.Password == encrytionpass).ToList().Count();
                if (model ==1)
                {
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");
                }
            }
            return View(acc);
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "home");
        }
    }
}