using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("order_details")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int OrderID { get; set; }

        public int Quantity { get; set; }
    }
}