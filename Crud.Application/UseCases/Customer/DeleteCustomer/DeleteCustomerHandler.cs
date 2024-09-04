using AutoMapper;
using Crud.Application.UseCases.DeleteCustomer.DTO;
using Crud.Application.UseCases.Shared;
using Crud.Domain.Interfaces;
using MediatR;

namespace Crud.Application.UseCases.DeleteCustomer;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerRequest, CustomerResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICustomerRepository _customerRepostory;
    private readonly IMapper _mapper;

    public DeleteCustomerHandler(IUnitOfWork unitOfWork, ICustomerRepository customerRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _customerRepostory = customerRepository;
        _mapper = mapper;
    }

    public async Task<CustomerResponse> Handle(DeleteCustomerRequest comand, CancellationToken cancellationToken)
    {
        var customerDb = await _customerRepostory.GetById(comand.id);

        if (customerDb is null) return default;

        _customerRepostory.Delete(customerDb);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CustomerResponse>(customerDb);
    }
}