using API.CORE.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]  // localhost:8081/api/Product/Create
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetAll")]        
        public ActionResult<List<ProductRequest>> GetAll( )
        {
           var products = new List<ProductRequest>();

            return products;
        }

        [HttpGet("GetByID")]
        public ActionResult<ProductRequest> GetByID(int id )
        {
            var product = new  ProductRequest();

            return product;
        }


        [HttpPost("Search")]
        public ActionResult<List<ProductRequest>> Search(ProductSearchRequest productSearchDTO)
        {
            var result = new List<ProductRequest>();
            //validate input

            if (ModelState.IsValid)
            {
               result.Add( new ProductRequest()); 
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



        [HttpPost("Create")]
        public ActionResult<ProductRequest> Create()
        {
            var product = new ProductRequest();

            return product;
        }



    }
}
