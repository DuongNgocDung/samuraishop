using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public string CategoryID { get; set; }

        public string Image { get; set; }

        public string MoreImages { get; set; }

        public string Price { get; set; }

        public string Promotion { get; set; }

        public string Warranty { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        [Required]
        public string Status { get; set; }

        public string HomeFlag { get; set; }

        public string HotFlag { get; set; }

        public string ViewCount { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }
    }
}