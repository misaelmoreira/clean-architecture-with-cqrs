using AutoMapper;
using Crud.Application.UseCases.CreateCustomer.DTO;
using Crud.Application.UseCases.Shared;
using Crud.Domain.Entities;
using Crud.Domain.Interfaces;
using MediatR;

namespace Crud.Application.UseCases.CreateCustomer;

public class UpdateCustomerHandler : IRequestHandler<CustomerRequest, CustomerResponse>
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

    public async Task<CustomerResponse> Handle(CustomerRequest request, CancellationToken cancellationToken)
    {
        var customer = _mapper.Map<Customer>(request);

        _customerRepostory.Create(customer);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CustomerResponse>(customer);
    }
}