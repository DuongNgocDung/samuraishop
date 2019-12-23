using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("product_tags")]
    public class ProductTag
    {
        [Key]
        public string ProductID { get; set; }

        [Key]
        public string TagID { get; set; }
    }
}