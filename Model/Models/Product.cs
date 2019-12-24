using Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto_increment
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        public string MoreImages { get; set; }

        public decimal Price { get; set; }

        public decimal? Promotion { get; set; }

        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }
    }
}