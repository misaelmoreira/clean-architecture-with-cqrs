using FluentValidation;
using Crud.Application.UseCases.UpdateCustomer.DTO;

namespace Crud.Application.UseCases.UpdateCustomer
{
    public sealed class UpdateCustomerValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerValidator()
        {
            //RuleFor(x => x.nome).NotEmpty().MinimumLength(3).MaximumLength(50);
            //RuleFor(x => x.email).NotEmpty().MaximumLength(50).EmailAddress();
        }
    }
}
