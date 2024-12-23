using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CommentDTO;
using NaderE_Shop.Application.Features.CommentF.Requests;

namespace NaderE_Shop.Application.Features.CommentF.Handlers
{
    public class GetCommentDetailHandler(ICommentRepository repository, IMapper mapper) : IRequestHandler<GetCommentDetailRequest, CommentDto>
    {
        private readonly ICommentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<CommentDto> Handle(GetCommentDetailRequest request, CancellationToken cancellationToken)
        {
            var comment = await _repository.GetCommentDetails(request.Id);
            return _mapper.Map<CommentDto>(comment);
        }
    }
}
