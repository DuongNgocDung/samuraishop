using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("order_detaails")]
    public class OrderDetail
    {
        [Key]
        public string ID { get; set}

        [Key]
        public string OrderID { get; set; }

        [Required]
        public string Quantity { get; set; }
    }
}