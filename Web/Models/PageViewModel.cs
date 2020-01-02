using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class PageViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Content { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual IEnumerable<PostViewModel> Posts { get; set; }
    }
}