using KOMPAdmin.DB;
using KOMPAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KOMPAdmin.Controllers
{
    public class AccountController : Controller
    {
         
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account
        [HttpPost]
        public ActionResult Login(AccountModel accountModel)
        {
            using (DBKOMPEntities db = new DBKOMPEntities())
            {
                if (db.Users.Any(m => m.UserLoginID.Equals(accountModel.userLoginId) && m.password.Equals(accountModel.password)))
                {
                    User user = db.Users.Where(m => m.UserLoginID.Equals(accountModel.userLoginId)).FirstOrDefault();
                    Session["Userdetails"] = user;
                    return RedirectToAction("Index","Dashboard");
                }
                else {
                    ModelState.AddModelError("Invalid","Invalid user credential.");
                    return View();
                }
            }
        }
    }
}