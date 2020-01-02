using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        [MaxLength(250)]
        public string Image { get; set; }

        [Required]
        [MaxLength(250)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}