using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)] // những cái là string thì nên set maxlength để không tốn bộ nhớ
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}