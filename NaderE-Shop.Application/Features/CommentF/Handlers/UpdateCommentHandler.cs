using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CommentDTO;
using NaderE_Shop.Application.Features.CommentF.Requests;

namespace NaderE_Shop.Application.Features.CommentF.Handlers
{
    public class UpdateCommentHandler(ICommentRepository repository, IMapper mapper) : IRequestHandler<UpdateCommentRequest, Unit>
    {
        private readonly ICommentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateCommentRequest request, CancellationToken cancellationToken)
        {
            var comment = await _repository.GetCommentDetails(request.UpdateComment.Id);
            _mapper.Map<UpdateCommentDto>(comment);
            await _repository.Update(comment);
            return Unit.Value;
        }
    }
}
