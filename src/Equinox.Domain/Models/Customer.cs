using System;
using NetDevPack.Domain;

namespace Equinox.Domain.Models
{
    public class Customer : Entity, IAggregateRoot
    {
        public Customer(Guid id, string name, int modelYear, int manifacturingYear)
        {
            Id = id;
            NameModel = name;
            ModelYear = modelYear;
            ManifacturingYear = manifacturingYear;
        }

        // Empty constructor for EF
        protected Customer() { }

        public string NameModel { get; private set; }

        public int ModelYear { get; private set; }

        public int ManifacturingYear { get; private set; }
    }
}