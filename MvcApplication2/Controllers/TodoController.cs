using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
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

        public ActionResult Index()
        {
            return View(maTodoList);
        }

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
        public ActionResult Edit(Todo item)
        {
            var result = maTodoList.Where(x => x.TodoID == item.TodoID);
            result.FirstOrDefault().Titre = item.Titre;
            return RedirectToAction("Index");
        }
    }
}
