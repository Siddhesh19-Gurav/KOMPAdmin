using KOMP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KOMP.Areas.Master.Controllers
{
    public class UsersController : Controller
    {
        UnitOfWork _unitofwork = new UnitOfWork();
        User _user;

        // GET: Master/Users
        public ActionResult Index()
        {
            IQueryable<User> users = _unitofwork.UserRepository.GetAll().OrderByDescending(m=> m.CreatedDate);
            return View(users);
        }
    }
}