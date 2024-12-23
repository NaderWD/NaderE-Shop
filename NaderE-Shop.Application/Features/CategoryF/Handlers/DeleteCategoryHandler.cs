using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.CategoryF.Requests;

namespace NaderE_Shop.Application.Features.CategoryF.Handlers
{
    public class DeleteCategoryHandler(ICategoryRepository repository) : IRequestHandler<DeleteCategoryRequest>
    {
        private readonly ICategoryRepository _repository = repository;

        public async Task Handle(DeleteCategoryRequest request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetCategoryDetails(request.Id);
            if (category != null)
            {
                await _repository.Delete(category);
            }
        }
    }
}
