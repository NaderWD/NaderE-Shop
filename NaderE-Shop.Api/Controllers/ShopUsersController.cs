using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.ShopUserDTO;
using NaderE_Shop.Application.Features.ShopUserF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopUsersController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<ShopUsersController>
        [HttpGet]
        public async Task<ActionResult<List<ShopUserListDto>>> Get()
        {
            var user = await _mediator.Send(new GetShopUsersListRequest());
            return user;
        }

        // GET api/<ShopUsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopUserDto>> Get(int id)
        {
            var user = await _mediator.Send(new GetShopUserDetailsRequest { Id = id });
            return user;
        }

        // POST api/<ShopUsersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateShopUserDto createUser)
        {
            var user = await _mediator.Send(new CreateShopUserRequest { CreateShopUser = createUser });
            return Ok(user);
        }

        // PUT api/<ShopUsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateShopUserDto updateUser)
        {
            await _mediator.Send(new UpdateShopUserRequest { Id = id, UpdateShopUser = updateUser });
            return NoContent();
        }

        // DELETE api/<ShopUsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteShopUserRequest { Id = id });
            return NoContent();
        }
    }
}
