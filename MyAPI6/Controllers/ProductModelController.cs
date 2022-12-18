using API.CORE;
using API.CORE.Dto;
using API.CORE.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductModelController : ControllerBase
    {
        private readonly IMapper mapper;

        private readonly IProductModelRepository productModelRepository;
        private readonly ILogger<ProductModelController> logger;

        private readonly IHostingEnvironment hostingEnvironment;

        public ProductModelController(IMapper mapper, IProductModelRepository productModelRepository, ILogger<ProductModelController> logger, IHostingEnvironment  environment)
        {
            this.mapper = mapper;
            this.logger = logger;
            this.productModelRepository = productModelRepository;
            this.hostingEnvironment = environment;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await productModelRepository.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError($"Exception Message: {ex.Message},StackTrace: {ex.StackTrace}");
            }

            return null;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] ProductModelDto productModelDto)
        {
            try
            {
                ProductModelValidator validator = new();
                var validatorResult = validator.Validate(productModelDto);
                if (!validatorResult.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, validatorResult.Errors);
                }
                var entity = mapper.Map<ProductModel>(productModelDto);
                string path = Path.Combine(this.hostingEnvironment.ContentRootPath, "Files\\");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // single file
                if (productModelDto.Image != null)
                {
                    using (FileStream stream = new FileStream(Path.Combine(path, productModelDto.Image.FileName), FileMode.Create))
                    {
                        productModelDto.Image.CopyTo(stream);
                    }
                    entity.ImageAvatar = productModelDto.Image.FileName;
                }

                //mutil files

                if (productModelDto.ListImage.Count  > 0)
                {
                    List<string> lstImageName = new List<string>();
                    foreach (var imageItem in productModelDto.ListImage)
                    {
                        using (FileStream stream = new FileStream(Path.Combine(path, imageItem.FileName), FileMode.Create))
                        {
                            imageItem.CopyTo(stream);
                        }
                        lstImageName.Add(imageItem.FileName);
                    }
                    entity.Images = String.Join(',', lstImageName);
                }


              
                entity.Code = Guid.NewGuid().ToString(); //
                entity = await productModelRepository.Add(entity);
                return Ok(entity.Id);
            }
            catch (Exception ex)
            {
                logger.LogError($"Exception Message: {ex.Message},StackTrace: {ex.StackTrace}");
            }

            return Ok(0);
        }
    }
}