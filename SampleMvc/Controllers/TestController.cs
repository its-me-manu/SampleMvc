using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvc.Models;

namespace SampleMvc.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Details()
        {
            return View("Details");
        }

        public ActionResult Submit(Test details)
        {
            if (details != null)
            {
                Test detailsForStore = new Test();
                detailsForStore = details;
                return View("Details");
            }
            return View("Details");
        }
    }
}