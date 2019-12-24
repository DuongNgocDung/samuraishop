﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Abstract
{
    public class Auditable
    {
        [MaxLength(250)]
        public string MetaKeyword { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        [Required]
        public bool Status { get; set; }

        public DateTime? CreateDate { get; set; }

        [MaxLength(50)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(50)]
        public string UpdateBy { get; set; }
    }
}