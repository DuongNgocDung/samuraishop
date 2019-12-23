using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("post_tags")]
    public class PostTag
    {
        [Key]
        public string PostID { get; set; }

        [Key]
        public string TagID { get; set; }
    }
}