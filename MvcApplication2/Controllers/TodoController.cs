using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    //[Authorize]
    public class TodoController : Controller
    {
        static private List<Todo> maTodoList = new List<Todo>()
        {
            new Todo() { TodoID = 1, Titre = "first test", Etat = true },
            new Todo() { TodoID = 2, Titre = "second test", Etat = true},
            new Todo() { TodoID = 3, Titre = "third test", Etat = true}
        };
        //
        // GET: /Todo/

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(maTodoList);
        }

        //[Authorize]
        public ActionResult Edit(int id = 0)
        {
            if (id == 0)
                return RedirectToAction("Index");

            var result = maTodoList.Where(x => x.TodoID == id);
            if (result.Count() <= 0)
                return RedirectToAction("Index");

            return View(result.FirstOrDefault()); 
        }

        [HttpPost]
        //[Authorize]
        public ActionResult Edit(Todo item)
        {
            //var item = new Todo();
            //item.TodoID = int.Parse(Request["TodoID"].ToString());
            //item.Titre = Request["Titre"].ToString();
            //item.Etat = bool.Parse(Request.Form.GetValues("Etat")[0].ToString());



            var result = maTodoList.Where(x => x.TodoID == item.TodoID);
            result.FirstOrDefault().Titre = item.Titre;

            return View(item);
        }
    }
}
