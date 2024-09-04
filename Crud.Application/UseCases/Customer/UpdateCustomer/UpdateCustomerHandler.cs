using AutoMapper;
using Crud.Application.UseCases.Shared;
using Crud.Application.UseCases.UpdateCustomer.DTO;
using Crud.Domain.Interfaces;
using MediatR;

namespace Crud.Application.UseCases.UpdateCustomer;

public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerRequest, CustomerResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICustomerRepository _customerRepostory;
    private readonly IMapper _mapper;

    public UpdateCustomerHandler(IUnitOfWork unitOfWork, ICustomerRepository customerRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _customerRepostory = customerRepository;
        _mapper = mapper;
    }

    public async Task<CustomerResponse> Handle(UpdateCustomerRequest comand, CancellationToken cancellationToken)
    {
        var customerDb = await _customerRepostory.GetById(comand.id);

        if (customerDb is null) return default;

        customerDb.Nome = comand.nome;
        customerDb.Email = comand.email;

        _customerRepostory.Update(customerDb);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CustomerResponse>(customerDb);
    }
}