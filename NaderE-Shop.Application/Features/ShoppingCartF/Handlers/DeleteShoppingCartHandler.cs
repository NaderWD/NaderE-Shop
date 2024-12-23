using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Handlers
{
    public class DeleteShoppingCartHandler(IShoppingCartRepository repository) : IRequestHandler<DeleteShoppingCartRequest>
    {
        private readonly IShoppingCartRepository _repository = repository;

        public async Task Handle(DeleteShoppingCartRequest request, CancellationToken cancellationToken)
        {
            var cart = await _repository.GetShoppingCartDetails(request.Id);
            if (cart != null)
            {
                await _repository.Delete(cart);
            }
        }
    }
}
