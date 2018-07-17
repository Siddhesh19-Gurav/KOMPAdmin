using KOMPAdmin.DB;
using KOMPAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KOMPAdmin.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plan
        public ActionResult Index()
        {
            using (DBKOMPEntities db = new DBKOMPEntities())
            {
              List<Plan> objPlanLiist=db.Plans.ToList();
              return View(objPlanLiist);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PlanModel objPlanModel)
        {
            if (ModelState.IsValid)
            {
                using (DBKOMPEntities db = new DBKOMPEntities())
                {
                    Plan objPlan = new Plan();
                    objPlan.Name = objPlanModel.Name;
                    objPlan.DaysInPlan = objPlanModel.DaysInPlan;
                    objPlan.ValidUpTo = objPlanModel.ValidUpTo;
                    objPlan.DeliveryCharges = objPlanModel.DeliveryCharges;
                    objPlan.Discount = objPlanModel.Discount;
                    objPlan.NightDeliveryCharges = objPlanModel.NightDeliveryCharges;
                    objPlan.IsActive = objPlanModel.IsActive==true?1:0;
                    db.Plans.Add(objPlan);
                    db.SaveChanges();
                }
                TempData["Message"] = "I";
                return RedirectToAction("Index","Plan");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            PlanModel objPlanModel = new PlanModel();
            using (DBKOMPEntities db = new DBKOMPEntities())
            {
                Plan objPlan = db.Plans.Where(m => m.Id == id).SingleOrDefault();
                objPlanModel.Name = objPlan.Name;
                objPlanModel.DaysInPlan = objPlan.DaysInPlan.GetValueOrDefault();
                objPlanModel.ValidUpTo = objPlan.ValidUpTo.GetValueOrDefault();
                objPlanModel.DeliveryCharges = objPlan.DeliveryCharges.GetValueOrDefault();
                objPlanModel.Discount = objPlan.Discount.GetValueOrDefault();
                objPlanModel.NightDeliveryCharges = objPlan.NightDeliveryCharges.GetValueOrDefault();
                objPlanModel.IsActive = objPlan.IsActive == 1 ? true : false;
            }
            return View(objPlanModel);
        }

        [HttpPost]
        public ActionResult Edit(PlanModel objPlanModel)
        {
            if (ModelState.IsValid)
            {
                using (DBKOMPEntities db = new DBKOMPEntities())
                {
                    Plan objPlan = db.Plans.Where(m => m.Id == objPlanModel.Id).SingleOrDefault();

                    objPlan.Name = objPlanModel.Name;
                    objPlan.DaysInPlan = objPlanModel.DaysInPlan;
                    objPlan.ValidUpTo = objPlanModel.ValidUpTo;
                    objPlan.DeliveryCharges = objPlanModel.DeliveryCharges;
                    objPlan.Discount = objPlanModel.Discount;
                    objPlan.NightDeliveryCharges = objPlanModel.NightDeliveryCharges;
                    objPlan.IsActive = objPlanModel.IsActive == true ? 1 : 0;

                    db.Entry(objPlan).State = EntityState.Modified;
                    db.SaveChanges();
                }
                TempData["Message"] = "U";
                return RedirectToAction("Index", "Plan");
            }
            else
            {
                return View();
            }
        }
    }
}