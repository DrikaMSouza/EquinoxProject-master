using System;
using Equinox.Domain.Commands.Validations;

namespace Equinox.Domain.Commands
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(Guid id, string name, int modelYear, int manifacturingYear)
        {
            Id = id;
            NameModel = name;
            ModelYear = modelYear;
            ManifacturingYear = manifacturingYear;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}