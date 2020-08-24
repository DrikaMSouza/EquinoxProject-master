using System;
using NetDevPack.Messaging;

namespace Equinox.Domain.Events
{
    public class CustomerUpdatedEvent : Event
    {
        public CustomerUpdatedEvent(Guid id, string name, int modelYear, int manifacturingYear)
        {
            Id = id;
            NameModel = name;
            ModelYear = modelYear;
            ManifacturingYear = manifacturingYear;
            AggregateId = id;
        }
        public Guid Id { get; set; }

        public string NameModel { get; private set; }

        public int ModelYear { get; private set; }

        public int ManifacturingYear { get; private set; }
    }
}