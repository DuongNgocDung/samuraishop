using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(20)]
        public string CustomerMobile { get; set; }

        [MaxLength(250)]
        public string CustomerMessage { get; set; }

        [MaxLength(250)]
        public string PaymentMethod { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        public DateTime? CreateDate { get; set; }

        [MaxLength(50)]
        public string CreateBy { get; set; }
    }
}