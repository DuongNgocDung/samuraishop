using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("visistor_statistics")]
    public class VisistorStatistic
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisistedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}