using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
    }
}
