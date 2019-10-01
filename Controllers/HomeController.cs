using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebActivatorEx;

namespace MvcDemo.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Tietoa()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Videos()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult React()
        {
            ViewBag.Message = "";

            return View();
        }

        public JsonResult GetName()
        {
            return Json(new { name = "World from server side" }, JsonRequestBehavior.AllowGet);
        }
    }
}