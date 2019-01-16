using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository_Mvc_Web.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Errors
        public ActionResult General()
        {
            return View();
        }

        public ActionResult Http404()
        {
            return View();
        }

        public ActionResult Http500()
        {
            return View();
        }
    }
}