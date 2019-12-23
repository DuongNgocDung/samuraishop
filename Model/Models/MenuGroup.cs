using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("menu_groups")]
    public class MenuGroup
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }
    }
}