using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPI6.Models;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]  // localhost:8081/api/Product/Create
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetAll")]        
        public ActionResult<List<ProductModel>> GetAll( )
        {
           var products = new List<ProductModel>();

            return products;
        }

        [HttpGet("GetByID")]
        public ActionResult<ProductModel> GetByID(int id )
        {
            var product = new  ProductModel();

            return product;
        }


        [HttpPost("Search")]
        public ActionResult<List<ProductModel>> Search(ProductSearchDTO productSearchDTO)
        {
            var result = new List<ProductModel>();
            //validate input

            if (ModelState.IsValid)
            {
               result.Add( new ProductModel()); 
            }
            else
            {
                return BadRequest();
            }

            return result;
        }

        [HttpPut("Put/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        // DELETE api/values/5
        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
        }



    }
}
