using System.ComponentModel.DataAnnotations;

namespace MyAPI6.Models
{
    public class ProductSearchDTO
    {
        [Required]
        public string Name { get; set; }


        [Range(0, 999)]
        [Required]

        public int Price { get; set; }
        public DateTime DateCreateTo { get; set; }


    }
}