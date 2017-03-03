using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication2.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
