using MediatR;
using NaderE_Shop.Application.DTOs.CommentDTO;

namespace NaderE_Shop.Application.Features.CommentF.Requests
{
    public class UpdateCommentRequest : IRequest<Unit>
    {
        public UpdateCommentDto UpdateComment { get; set; }
    }
}
