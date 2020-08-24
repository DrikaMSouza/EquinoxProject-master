using System;
using FluentValidation;

namespace Equinox.Domain.Commands.Validations
{
    public abstract class CustomerValidation<T> : AbstractValidator<T> where T : CustomerCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.NameModel)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        protected void ValidateModelYear()
        {
            RuleFor(c => c.ModelYear)
                .NotEmpty()
                .Must(HaveMinimumModelYear)
                .WithMessage("The model year must have actual year");
        }

        protected void ValidateManifacturingYear()
        {
            RuleFor(c => c.ManifacturingYear)
                .Must(HaveMinimumManifacturingYear)
                .NotEmpty()
                .WithMessage("The manifacturing year must have 1 year or less");
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected static bool HaveMinimumModelYear(int modelYear)
        {
            return modelYear == DateTime.Now.Year;
        }

        protected static bool HaveMinimumManifacturingYear(int manifacturingYear)
        {
            return manifacturingYear <= DateTime.Now.AddYears(-1).Year;
        }

    }
}