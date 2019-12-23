using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerMobile { get; set; }

        public string CustomerMessage { get; set; }

        public string PaymentMethod { get; set; }

        [Required]
        public string PaymentStatus { get; set; }

        [Required]
        public string Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }
    }
}