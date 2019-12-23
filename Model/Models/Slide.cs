using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("slides")]
    public class Slide
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string URL { get; set; }

        public string DisplayPrder { get; set; }

        [Required]
        public string Status { get; set; }
    }
}