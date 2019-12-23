using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("pages")]
    public class Page
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        [Required]
        public string Status { get; set; }
    }
}