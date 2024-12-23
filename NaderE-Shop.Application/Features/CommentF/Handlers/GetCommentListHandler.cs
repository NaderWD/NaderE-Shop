using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CommentDTO;
using NaderE_Shop.Application.Features.CommentF.Requests;

namespace NaderE_Shop.Application.Features.CommentF.Handlers
{
    public class GetCommentListHandler(ICommentRepository repository, IMapper mapper) : IRequestHandler<GetCommentListRequest, List<CommentListDto>>
    {
        private readonly ICommentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<CommentListDto>> Handle(GetCommentListRequest request, CancellationToken cancellationToken)
        {
            var comments = await _repository.GetAllComments();
            return _mapper.Map<List<CommentListDto>>(comments);
        }
    }
}
