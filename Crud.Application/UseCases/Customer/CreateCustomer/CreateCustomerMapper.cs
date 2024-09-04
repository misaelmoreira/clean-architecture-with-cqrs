using AutoMapper;
using Crud.Domain.Entities;
using Crud.Application.UseCases.CreateCustomer.DTO;
using Crud.Application.UseCases.Shared;

namespace Crud.Application.UseCases.CreateCustomer
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CustomerRequest, Customer>();
            CreateMap<Customer, CustomerResponse>();
        }
    }
}
