using Crud.Application.UseCases.CreateCustomer.DTO;
using Crud.Application.UseCases.DeleteCustomer.DTO;
using Crud.Application.UseCases.GetAllCustomer.DTO;
using Crud.Application.UseCases.Shared;
using Crud.Application.UseCases.UpdateCustomer.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Crud.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly IMediator _mediator;

    public ClientesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("/todos")]
    public async Task<ActionResult<List<CustomerResponse>>> GetAll()
    {
        var response = await _mediator.Send(new GetAllCustomerRequest());
        return Ok(response);
    }

    [HttpPost]
    [Route("/criar")]
    public async Task<ActionResult> Create(CustomerRequest request)
    {
        var userId = await _mediator.Send(request);
        return Ok(userId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<CustomerResponse>> Update(Guid id, UpdateCustomerRequest request)
    {
        if (id != request.id)
            return BadRequest();

        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id)
    {
        if (id is null)
            return BadRequest();

        var deleteCustomerRequest = new DeleteCustomerRequest(id.Value);

        var response = await _mediator.Send(deleteCustomerRequest);
        return Ok(response);
    }
}