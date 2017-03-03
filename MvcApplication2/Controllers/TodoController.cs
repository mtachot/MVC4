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

            var todo = result.FirstOrDefault();
            if (todo != null)
                todo.CreatedDate = DateTime.Now;
            
            return View(todo); 
        }

        [HttpPost]
        // HttpPost = Event levé lors de la soumission du formulaire
        //[Authorize]
        public ActionResult Edit(Todo item)
        {
            // Test des validations annotations dans le modèle
            if (ModelState.IsValid)
            {
                var result = maTodoList.Where(x => x.TodoID == item.TodoID);
                var todo = result.FirstOrDefault();
                if (todo != null)
                    todo.Titre = item.Titre;
            }

            //var item = new Todo();
            //item.TodoID = int.Parse(Request["TodoID"].ToString());
            //item.Titre = Request["Titre"].ToString();
            //item.Etat = bool.Parse(Request.Form.GetValues("Etat")[0].ToString());



            

            return View(item);
        }
    }
}
