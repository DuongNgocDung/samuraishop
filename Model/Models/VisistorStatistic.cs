using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("visistor_statistics")]
    public class VisistorStatistic
    {
        [Key]
        public string ID { get; set; }

        public DateTime? VisistedDate { get; set; }

        public string IPAddress { get; set; }
    }
}