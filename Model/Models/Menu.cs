using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("menus")]
    public class Menu
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string URL { get; set; }

        public string DisplayOrder { get; set; }

        public string GroupID { get; set; }

        public string Target { get; set; }

        [Required]
        public string Status { get; set; }
    }
}