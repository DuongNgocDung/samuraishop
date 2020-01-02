using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class VisistorStatisticViewModel
    {
        public Guid ID { get; set; }
        public DateTime VisistedDate { get; set; }
        public string IPAddress { get; set; }
    }
}