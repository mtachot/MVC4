using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Todo
    {
        public int TodoID { get; set; }
        public string Titre { get; set; }
        public bool Etat { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedTime { get; set; }
        public virtual ICollection<Comment> Comments {get;set;}
    }
}