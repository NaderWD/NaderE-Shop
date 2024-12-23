using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.CommentF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.CommentF.Handlers
{
    public class CreateCommentHandler(ICommentRepository repository, IMapper mapper) : IRequestHandler<CreateCommentRequest, int>
    {
        private readonly ICommentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateCommentRequest request, CancellationToken cancellationToken)
        {
            var comment = _mapper.Map<Comment>(request.CreateComment);
            await _repository.Add(comment);
            return comment.Id;
        }
    }
}
