using System.ComponentModel.DataAnnotations;

namespace API.CORE.Request
{
    public class ProductSearchRequest
    {
        [Required]
        public string Name { get; set; }


        [Range(0, 999)]
        [Required]

        public int Price { get; set; }
        public DateTime DateCreateTo { get; set; }


    }
}