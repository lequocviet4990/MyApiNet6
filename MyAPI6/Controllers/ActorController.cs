using API.CORE;
using API.CORE.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IMapper mapper;

        private readonly IActorRepository actorRepository;

        public ActorController(IMapper mapper, IActorRepository actorRepository)
        {
            this.mapper = mapper;

            this.actorRepository = actorRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetAll()
        {
            var lstData = await actorRepository.GetAll();
            return lstData;
        }
    }
}