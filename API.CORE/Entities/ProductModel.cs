using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.CORE.Entities
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int? TimeMaintenance { get; set; }
        public int? TimeInsurance { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsPublic { get; set; }
        public string  Images { get; set; }
        public string  ImageAvatar { get; set; } 
 
    }
}
