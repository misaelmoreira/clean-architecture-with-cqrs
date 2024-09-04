using AutoMapper;
using Crud.Application.UseCases.Shared;
using Crud.Application.UseCases.UpdateCustomer.DTO;
using Crud.Domain.Entities;

namespace Crud.Application.UseCases.UpdateCustomer
{
    public sealed class UpdateCustomerMapper : Profile
    {
        public UpdateCustomerMapper()
        {
            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<Customer, CustomerResponse>();
        }
    }
}
