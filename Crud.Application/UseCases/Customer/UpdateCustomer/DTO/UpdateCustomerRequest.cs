using Crud.Application.UseCases.Shared;
using MediatR;

namespace Crud.Application.UseCases.UpdateCustomer.DTO;

public sealed record UpdateCustomerRequest(Guid id, string nome, string email, string telefone) : IRequest<CustomerResponse>;