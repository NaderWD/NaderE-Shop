using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.CommentF.Requests;

namespace NaderE_Shop.Application.Features.CommentF.Handlers
{
    public class DeleteCommentHandler(ICommentRepository repository) : IRequestHandler<DeleteCommentRequest>
    {
        private readonly ICommentRepository _repository = repository;

        public async Task Handle(DeleteCommentRequest request, CancellationToken cancellationToken)
        {
            var comment = await _repository.GetCommentDetails(request.Id);
            if (comment != null)
            {
                await _repository.Delete(comment);
            }
        }
    }
}