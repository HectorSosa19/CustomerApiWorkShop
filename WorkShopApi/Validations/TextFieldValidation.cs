using FluentValidation;
using WorkShopApi.Model;

namespace WorkShopApi.Validations
{
    public class TextFieldValidation : AbstractValidator<CustomerModel>
    {
        public TextFieldValidation()
        {
            RuleFor(ValidationOfCustomer => ValidationOfCustomer.FirstName).NotEmpty().WithMessage("You have to Write u name");
            RuleFor(ValidationOfCustomer => ValidationOfCustomer.Age).NotNull().WithMessage("Look Man or Miss you have to put your Age");
            RuleFor(ValidationOfCustomer => ValidationOfCustomer.ZipCode).NotEqual(10).WithMessage("I'm So Sorry It Can't be 10");
            RuleFor(ValidationOfCustomer => ValidationOfCustomer.DateOfBirth).Must(BeAValidDate).WithMessage("The Start date is required ☀ ");
            RuleFor(ValidationOfCustomer => ValidationOfCustomer.IsHuman).Must(x => x == false || x == true).WithMessage("It has to be True Or False Mr. or Mrs.");

        }
        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
