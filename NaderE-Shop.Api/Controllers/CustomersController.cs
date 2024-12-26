using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.CustomerDTO;
using NaderE_Shop.Application.Features.CustomerF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<ActionResult<List<CustomerListDto>>> Get()
        {
            var customers = await _mediator.Send(new GetCustomerListRequest());
            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> Get(int id)
        {
            var customer = await _mediator.Send(new GetCustomerDetailRequest { Id = id });
            return customer;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCustomerDto createCustomer)
        {
            var customer = await _mediator.Send(new CreateCustomerRequest { CreateCustomer = createCustomer });
            return Ok(customer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateCustomerDto updateCustomer)
        {
            await _mediator.Send(new UpdateCustomerRequest { Id = id, UpdateCustomer = updateCustomer });
            return NoContent();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCustomerRequest { Id = id });
            return NoContent();
        }
    }
}
