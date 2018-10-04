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
        public ActionResult OnSubmit(DateModel model)
        {
            if (ModelState.IsValid)
            {
                // do your stuff like: save to database and redirect to required page.
                
            }
            return View("Index", model);

            // If we got this far, something failed, redisplay form

        }
    }
}