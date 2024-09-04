using Crud.Application.UseCases.Shared;
using MediatR;

namespace Crud.Application.UseCases.CreateCustomer.DTO;

public sealed record CustomerRequest(string nome, string email, string telefone) : IRequest<CustomerResponse>;