using FluentValidation;
using System.Data;

namespace API.CORE.Dto
{
    public class MoviesDto
    {
        public int Id { get; set; }

        
        public string Title { get; set; }

        public string Genre { get; set; } //thể loại
        public decimal Price { get; set; } 
        public DateTime PublicDate { get; set; }

       
    }

   

    public class MoviesValidator : AbstractValidator<MoviesDto>
    {
        public bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
        public MoviesValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please specify Title");
            RuleFor(x => x.Genre).NotEmpty().WithMessage("Please specify Genre");
          
            RuleFor(x => x.PublicDate).Must(BeAValidDate).WithMessage("Please PublicDate is datetime");
           
            

        }
    }


    public enum TypeGenre
    {
        Error = 1,
        Warning = 2,
        Notice = 3
    }

}
