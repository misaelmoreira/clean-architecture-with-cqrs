using Crud.Application.UseCases.Shared;
using MediatR;

namespace Crud.Application.UseCases.DeleteCustomer.DTO;

public sealed record DeleteCustomerRequest(Guid id) : IRequest<CustomerResponse>;