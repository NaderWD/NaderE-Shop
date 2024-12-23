using MediatR;
using NaderE_Shop.Application.DTOs.CommentDTO;

namespace NaderE_Shop.Application.Features.CommentF.Requests
{
    public class GetCommentListRequest : IRequest<List<CommentListDto>>
    {

    }
}
