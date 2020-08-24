using System;
using Equinox.Domain.Commands.Validations;

namespace Equinox.Domain.Commands
{
    public class RegisterNewCustomerCommand : CustomerCommand
    {
        public RegisterNewCustomerCommand(string name, int modelYear, int manifacturingYear)
        {
            NameModel = name;
            ModelYear = modelYear;
            ManifacturingYear = manifacturingYear;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}