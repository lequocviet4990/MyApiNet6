using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace API.CORE.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public ProductModel  ProductModel { get; set; } // Product models   id =10, 11 , Product: productmodelID = 12 
        public string  Name { get; set; }
        public string  Description { get; set; }
        public string  SerialNo { get; set; } 
        public DateTime? CreateDate { get; set; }
        public string  CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string  UpdateBy { get; set; }
        public bool? IsDelete { get; set; }
    }
}