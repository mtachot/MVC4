using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MonDeuxiemeController : Controller
    {
        //
        // GET: /MonDeuxieme/

        public ActionResult Index()
        {
            return View();
        }

        public string test2()
        { 
            return "mon test avec un string"; 
        }

    }
}
