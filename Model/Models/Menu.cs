using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        public int GroupID { get; set; }

        [MaxLength(10)]
        public string Target { get; set; }

        public bool Status { get; set; }
    }
}