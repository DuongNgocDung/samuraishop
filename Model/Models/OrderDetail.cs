using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("order_detaails")]
    public class OrderDetail
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        public int OrderID { get; set; }

        public int Quantity { get; set; }
    }
}