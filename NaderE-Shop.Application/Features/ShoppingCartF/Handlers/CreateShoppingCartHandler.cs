using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Handlers
{
    public class CreateShoppingCartHandler(IShoppingCartRepository repository, IMapper mapper) : IRequestHandler<CreateShoppingCartRequest, int>
    {
        private readonly IShoppingCartRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateShoppingCartRequest request, CancellationToken cancellationToken)
        {
            var cart = _mapper.Map<ShoppingCart>(request.CreateShoppingCart);
            await _repository.Add(cart);
            return cart.Id;

        }
    }
}
