using AutoMapper;
using Crud.Application.UseCases.Shared;
using Crud.Domain.Entities;

namespace Crud.Application.UseCases.GetAllCustomer
{
    public sealed class GetAllCustomerMapper : Profile
    {
        public GetAllCustomerMapper()
        {
            CreateMap<Customer, CustomerResponse>();
        }
    }
}
