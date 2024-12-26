using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.OrderDTO;
using NaderE_Shop.Application.Features.OrderF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<ActionResult<List<OrderListDto>>> Get()
        {
            var orders = await _mediator.Send(new GetOrderListRequest());
            return orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> Get(int id)
        {
            var order = await _mediator.Send(new GetOrderDetailRequest { Id = id });
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateOrderDto createOrder)
        {
            var order = await _mediator.Send(new CreateOrderRequest { CreateOrder = createOrder });
            return Ok(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateOrderDto updateOrder)
        {
            await _mediator.Send(new UpdateOrderRequest { Id = id, UpdateOrder = updateOrder });
            return NoContent();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteOrderRequest { Id = id });
            return NoContent();
        }
    }
}
