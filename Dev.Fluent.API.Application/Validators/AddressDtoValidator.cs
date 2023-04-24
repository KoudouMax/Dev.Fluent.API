using Dev.Fluent.API.Application.DTOs;
using FluentValidation;

namespace Dev.Fluent.Application.Validators
{
    public class AddressDtoValidator: AbstractValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            // Validate address is not longer than 60 chars as many APIs for carriers doesn't allow
            // longer address as they cannot be at the shipment label
            RuleFor(obj => obj.Street1).NotNull().NotEmpty().Length(1, 60);
            RuleFor(obj => obj.Street2).Length(1, 60);

            // Validate Country
            RuleFor(obj => obj.Country).NotNull().NotEmpty().WithMessage("Please add the destination country");

            // Validate City and ZIP
            RuleFor(obj => obj.PostalCode).NotNull().NotEmpty().WithMessage("Please add reciever postcode");
            RuleFor(obj => obj.PostalCode).Must(ValidPostCode).WithMessage("Postalcode is not valid");
            RuleFor(obj => obj.City).NotNull().NotEmpty().WithMessage("Please add the reciever city");
        }

        private bool ValidPostCode(string postalCode)
        {
            // Add logic for validating postalcode here...
            return true;
        }
    }
}
