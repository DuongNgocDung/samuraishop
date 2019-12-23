using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("system_configs")]
    public class SystemConfig
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Code { get; set; }

        public string ValueString { get; set; }

        public string ValueInt { get; set; }
    }
}