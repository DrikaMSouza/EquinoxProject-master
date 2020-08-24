using AutoMapper;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands;

namespace Equinox.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModel, RegisterNewCustomerCommand>()
                .ConstructUsing(c => new RegisterNewCustomerCommand(c.NameModel, c.ModelYear, c.ManifacturingYear));
            CreateMap<CustomerViewModel, UpdateCustomerCommand>()
                .ConstructUsing(c => new UpdateCustomerCommand(c.Id, c.NameModel, c.ModelYear, c.ManifacturingYear));
        }
    }
}
