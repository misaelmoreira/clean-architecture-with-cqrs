using FluentValidation;
using Crud.Application.UseCases.DeleteCustomer.DTO;

namespace Crud.Application.UseCases.DeleteCustomer
{
    public sealed class DeleteCustomerValidator : AbstractValidator<DeleteCustomerRequest>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(x => x.id).NotEmpty();
        }
    }
}
