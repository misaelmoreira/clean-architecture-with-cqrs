using Crud.Application.UseCases.Shared;
using MediatR;

namespace Crud.Application.UseCases.GetAllCustomer.DTO;

public sealed record GetAllCustomerRequest() : IRequest<List<CustomerResponse>>;