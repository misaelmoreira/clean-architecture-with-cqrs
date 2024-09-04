using AutoMapper;
using Crud.Domain.Entities;
using Crud.Application.UseCases.Shared;
using Crud.Application.UseCases.DeleteCustomer.DTO;

namespace Crud.Application.UseCases.DeleteCustomer
{
    public sealed class DeleteCustomerMapper : Profile
    {
        public DeleteCustomerMapper()
        {
            CreateMap<DeleteCustomerRequest, Customer>();
            CreateMap<Customer, CustomerResponse>();
        }
    }
}
