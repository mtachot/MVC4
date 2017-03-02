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
    }
}