using MediatR;
using Microsoft.AspNetCore.Mvc;
using NaderE_Shop.Application.DTOs.CommentDTO;
using NaderE_Shop.Application.Features.CommentF.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaderE_Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // GET: api/<CommentsController>
        [HttpGet]
        public async Task<ActionResult<List<CommentListDto>>> Get()
        {
            var comments = await _mediator.Send(new GetCommentListRequest());
            return comments;
        }

        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentDto>> Get(int id)
        {
            var comments = await _mediator.Send(new GetCommentDetailRequest { Id = id });
            return comments;
        }

        // POST api/<CommentsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCommentDto createComment)
        {
            var comment = await _mediator.Send(new CreateCommentRequest { CreateComment = createComment });
            return Ok(comment);
        }

        // PUT api/<CommentsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateCommentDto updateComment)
        {
            await _mediator.Send(new UpdateCommentRequest { Id = id, UpdateComment = updateComment });
            return NoContent();
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCommentRequest { Id = id });
            return NoContent();
        }
    }
}
