using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Todo
    {
        public int TodoID { get; set; }

        [DisplayName("Mon titre")]
        [Required(ErrorMessage="Merci de remplir le titre")]
        [StringLength(50, ErrorMessage="50 caractères max")]
        [TodoValidationAttribute(5)]
        public string Titre { get; set; }
        public bool Etat { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date de création :")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedTime { get; set; }
        public virtual ICollection<Comment> Comments {get;set;}

        // Regex validation adresse Mail :
        // [RegularExpression(".+\\@.+\\..+")]
    }
}