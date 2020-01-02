using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }

        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { get; set; }
    }
}