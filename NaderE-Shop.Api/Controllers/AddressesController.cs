﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.AddressDTO;
using NaderE_Shop.Application.Features.AddressF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<AddressesController>
        [HttpGet]
        public async Task<ActionResult<List<AddressListDto>>> Get()
        {
            var addresses = await _mediator.Send(new GetAddressListRequest());
            return Ok(addresses);
        }

        // GET api/<AddressesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddressDto>> Get(int id)
        {
            var address = await _mediator.Send(new GetAddressDetailsRequest { Id = id });
            return Ok(address);
        }

        // POST api/<AddressesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateAddressDto createAddress)
        {
            var address = await _mediator.Send(new CreateAddressRequest { CreateAddress = createAddress });
            return Ok(address);
        }

        // PUT api/<AddressesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateAddressDto updateAddress)
        {
            await _mediator.Send(new UpdateAddressRequest { Id = id, UpdateAddress = updateAddress });
            return NoContent();
        }

        // DELETE api/<AddressesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteAddressRequest { Id = id });
            return NoContent();
        }
    }
}
