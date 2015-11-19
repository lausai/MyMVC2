using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC2.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Form(string FormData)
        {
            if (FormData != null)
            {
                var strs = FormData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                ViewData["FormData"] = strs.Count().ToString();
            }
            return View();
        }
    }
}
