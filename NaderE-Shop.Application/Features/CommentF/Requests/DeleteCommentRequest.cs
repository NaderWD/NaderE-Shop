using MediatR;

namespace NaderE_Shop.Application.Features.CommentF.Requests
{
    public class DeleteCommentRequest : IRequest
    {
        public int Id { get; set; }
    }
}
