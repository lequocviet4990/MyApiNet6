using API.CORE.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace API.CORE.Dto
{
    public class ProductModelDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TimeMaintenance { get; set; }

        public int TimeInsurance { get; set; }

        public bool? IsDelete { get; set; }
        public bool? IsPublic { get; set; }
   

        public IFormFile Image { get; set; }
        public IList<IFormFile> ListImage { get; set; }


       

    }

    public class ProductModelValidator : AbstractValidator<ProductModelDto>
    {
        public bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

        public ProductModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify Name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please specify Description");
            RuleFor(x => x.TimeMaintenance).NotEmpty().WithMessage("Please specify TimeMaintenance");
            RuleFor(x => x.TimeInsurance).NotEmpty().WithMessage("Please specify TimeInsurance");
        }
    }
}