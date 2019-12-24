using System;

namespace Model.Abstract
{
    public interface IAuditable
    {
        bool Status { get; set; }

        string MetaKeyword { get; set; }

        string MetaDescription { get; set; }

        DateTime? CreateDate { get; set; }

        string CreateBy { get; set; }

        DateTime? UpdateDate { get; set; }

        string UpdateBy { get; set; }
    }
}