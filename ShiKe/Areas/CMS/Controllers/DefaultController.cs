using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace ShiKe.Areas.CMS.Controllers
{
    public class DefaultController : Controller
    {
        // GET: CMS/Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SysManage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            return RedirectToAction("SysManage", "Default",new { area="CMS"});
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Grid()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

    }
}