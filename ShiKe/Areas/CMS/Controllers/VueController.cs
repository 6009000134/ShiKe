using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShiKe.Areas.CMS.Controllers
{
    public class VueController : Controller
    {
        // GET: CMS/Vue
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VueRouter()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
    }
}