using DateComparer;
using Datediff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Datediff.Controllers
{
    public class DateDiffController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OnSubmit(DateViewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                if (!DateCompare.IsValidDateString(model.FromDate))
                {
                    ModelState.AddModelError("FromDate", "Please Enter Valid Date in dd/MM/yyyy format");
                }
                else if (!DateCompare.IsValidDateString(model.ToDate))
                {
                    ModelState.AddModelError("ToDate", "Please Enter Valid Date in dd/MM/yyyy format");
                }
                else if (!DateCompare.IsFromDateLessThanToDate(model.FromDate, model.ToDate))
                {
                    ModelState.AddModelError("FromDate", "From Date should be less than To Date");
                }
                else
                {
                    model.TotalDays = DateCompare.GetDifference(model.FromDate, model.ToDate);
                }
            }

            return View("Index", model);


        }
    }
}