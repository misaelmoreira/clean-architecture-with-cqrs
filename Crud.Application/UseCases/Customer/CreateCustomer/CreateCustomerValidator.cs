using FluentValidation;
using Crud.Application.UseCases.CreateCustomer.DTO;

namespace Crud.Application.UseCases.CreateCustomer
{
    public sealed class UpdateCustomerValidator : AbstractValidator<CustomerRequest>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.nome).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.email).NotEmpty().MaximumLength(50).EmailAddress();
        }
    }
}
