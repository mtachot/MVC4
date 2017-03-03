using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Models
{
    public class TodoModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Todo todo = new Todo();
            var request = controllerContext.HttpContext.Request;

            todo.Titre = request["Titre"].ToString();
            bool boolRes = false;
            if(bool.TryParse(request.Form.GetValues("Etat")[0], out boolRes))
                todo.Etat = boolRes;
            int intRes = 0;
            if (int.TryParse(request["TodoId"].ToString(), out intRes))
                todo.TodoID = intRes;
            todo.Description = request["Description"].ToString();
            todo.UpdatedTime = DateTime.Now;
            todo.CreatedDate = DateTime.Now;

            return todo;
        }
    }
}