using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ProductF.Requests;

namespace NaderE_Shop.Application.Features.ProductF.Handlers
{
    public class DeleteProductHandler(IProductRepository repository) : IRequestHandler<DeleteProductRequest>
    {
        private readonly IProductRepository _repository = repository;

        public async Task Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetProductDetails(request.Id);
            if (product != null)
            {
                await _repository.Delete(product);
            }
        }
    }
}
