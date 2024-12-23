using MediatR;
using NaderE_Shop.Application.DTOs.CommentDTO;

namespace NaderE_Shop.Application.Features.CommentF.Requests
{
    public class GetCommentDetailRequest : IRequest<CommentDto>
    {
        public int Id { get; set; }
    }
}
