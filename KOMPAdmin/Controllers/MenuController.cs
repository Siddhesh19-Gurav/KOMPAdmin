using KOMPAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KOMPAdmin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            List<SelectListItem> ObjList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Day", Value = "D" },
                new SelectListItem { Text = "Night", Value = "N" },
                new SelectListItem { Text = "Both", Value = "B" },
                new SelectListItem { Text = "Customised", Value = "C" },
                new SelectListItem { Text = "Nutrimeal", Value = "N" },

            };
            //Assigning generic list to ViewBag
            ViewBag.ShowInBoth = ObjList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(MenuModel objMenuModel)
        {
            return View();
        }
    }
}