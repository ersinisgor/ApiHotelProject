using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.Validation_Rules.GuestValidationRules
{
  public class UpdateGuestValidator: AbstractValidator<UpdateGuestDto>
  {
  public UpdateGuestValidator()
    {

      RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
      RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname cannot be empty");
      RuleFor(x => x.City).NotEmpty().WithMessage("City cannot be empty");
      RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter at least 3 characters");
      RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Please enter at least 2 characters");
      RuleFor(x => x.City).MinimumLength(2).WithMessage("Please enter at least 2 characters");
      RuleFor(x => x.Name).MaximumLength(20).WithMessage("Please enter max 20 characters");
      RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Please enter max 30 characters");
      RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter max 20 characters");


    }
  }
}
