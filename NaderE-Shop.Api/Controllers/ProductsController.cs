using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.ProductDTO;
using NaderE_Shop.Application.Features.ProductF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<List<ProductListDto>>> Get()
        {
            var produsts = await _mediator.Send(new GetProductsListRequest());
            return produsts;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var product = await _mediator.Send(new GetProductDetailsRequest { Id = id });
            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateProductDto createProduct)
        {
            var product = await _mediator.Send(new CreateProductRequest { CreateProduct = createProduct });
            return Ok(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateProductDto updateProduct)
        {
            await _mediator.Send(new UpdateProductRequest { Id = id, UpdateProduct = updateProduct });
            return NoContent();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteProductRequest { Id = id });
            return NoContent();
        }
    }
}
