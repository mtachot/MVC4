using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MaDeuxiemeAction()
        {
            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            return View(id);
        }
    }
}
