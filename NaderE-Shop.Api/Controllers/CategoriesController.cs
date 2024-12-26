using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.CategoryDTO;
using NaderE_Shop.Application.Features.CategoryF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<List<CategoryListDto>> Get()
        {
            var categories = await _mediator.Send(new GetCategoryListRequest());
            return categories;
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> Get(int id)
        {
            var category = await _mediator.Send(new GetCategoryDetailRequest { Id = id });
            return category;
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCategoryDto createCategory)
        {
            var category = await _mediator.Send(new CreateCategoryRequest { CreateCategory = createCategory });
            return Ok(category);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateCategoryDto updateCategory)
        {
            await _mediator.Send(new UpdateCategoryRequest { Id = id, UpdateCategory = updateCategory });
            return NoContent();
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCategoryRequest { Id = id });
            return NoContent();
        }
    }
}
