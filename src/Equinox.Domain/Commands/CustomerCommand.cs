using System;
using NetDevPack.Messaging;

namespace Equinox.Domain.Commands
{
    public abstract class CustomerCommand : Command
    {
        public Guid Id { get; protected set; }

        public string NameModel { get; protected set; }

        public int ModelYear { get; protected set; }

        public int ManifacturingYear { get; protected set; }
    }
}