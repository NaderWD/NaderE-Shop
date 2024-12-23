using MediatR;
using NaderE_Shop.Application.DTOs.CommentDTO;

namespace NaderE_Shop.Application.Features.CommentF.Requests
{
    public class CreateCommentRequest : IRequest<int>
    {
        public CreateCommentDto CreateComment { get; set; }
    }
}
