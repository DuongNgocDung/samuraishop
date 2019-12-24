using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [Required]
        public bool Status { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public DateTime? CreateDate { get; set; }

        [MaxLength(50)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(50)]
        public string UpdateBy { get; set; }
    }
}