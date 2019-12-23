using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("tags")]
    public class Tag
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}