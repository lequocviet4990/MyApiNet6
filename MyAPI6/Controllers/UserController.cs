using API.CORE;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        private IMovieRepository  movieRepository;
        public  UserController(IUserService userService, IMovieRepository movieRepository)
        {
            this.userService = userService;
            this.movieRepository = movieRepository;
        }

       
        [HttpPost("Login")]
        public IActionResult Login(AuthenticateRequest authenticateRequest)
        {
            var response =  userService.Authenticate(authenticateRequest);
            if (response == null)
            {
                return BadRequest(new { message = "Login fail" });
            }


            return Ok(response);
        }
        [Authorize]
        [HttpGet("GetAll")] 
        public async Task<IActionResult> GetAllMovie ( )
        {
          

            return Ok(await movieRepository.GetAll());
        }
    }
}
