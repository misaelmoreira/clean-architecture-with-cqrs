using AutoMapper;
using Crud.Application.UseCases.GetAllCustomer.DTO;
using Crud.Application.UseCases.Shared;
using Crud.Domain.Interfaces;
using MediatR;

namespace Crud.Application.UseCases.GetAllCustomer;

public sealed class GetAllCustomerHandler : IRequestHandler<GetAllCustomerRequest, List<CustomerResponse>>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetAllCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<List<CustomerResponse>> Handle(GetAllCustomerRequest request, CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetAll();

        return _mapper.Map<List<CustomerResponse>>(customers);
    }
}