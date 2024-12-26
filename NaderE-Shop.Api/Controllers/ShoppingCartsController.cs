using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<ShoppingCartsController>
        [HttpGet]
        public async Task<ActionResult<List<ShoppingCartListDto>>> Get()
        {
            var carts = await _mediator.Send(new GetShoppingCartsListRequest());
            return carts;
        }

        // GET api/<ShoppingCartsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingCartDto>> Get(int id)
        {
            var cart = await _mediator.Send(new GetShoppingCartDetailsRequest { Id = id });
            return cart;
        }

        // POST api/<ShoppingCartsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateShoppingCartDto createCart)
        {
            var cart = await _mediator.Send(new CreateShoppingCartRequest { CreateShoppingCart = createCart });
            return Ok(cart);
        }

        // PUT api/<ShoppingCartsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateShoppingCartDto updateCart)
        {
            await _mediator.Send(new UpdateShoppingCartRequest { Id = id, UpdateShoppingCart = updateCart });
            return NoContent();
        }

        // DELETE api/<ShoppingCartsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteShoppingCartRequest { Id = id });
            return NoContent();
        }

        // ChangeShoppingCartStatusToPaid api/<ShoppingCartsController>/ChangeToPaid/5
        [HttpPut("ChangeToPaid/{id}")]
        public async Task<ActionResult> ChangeToPaid(int id, [FromBody] ChangeShoppingCartStatusToPaidDto changeCartStatusToPaid)
        {
            await _mediator.Send(new UpdateShoppingCartRequest { Id = id, ChangeToPaid = changeCartStatusToPaid });
            return NoContent();
        }
    }
}
