using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Handlers
{
    public class GetShoppingCartsListHandler(IShoppingCartRepository repository, IMapper mapper) : IRequestHandler<GetShoppingCartsListRequest, List<ShoppingCartListDto>>
    {
        private readonly IShoppingCartRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<ShoppingCartListDto>> Handle(GetShoppingCartsListRequest request, CancellationToken cancellationToken)
        {
            var carts = await _repository.GetAllShoppingCarts();
            return _mapper.Map<List<ShoppingCartListDto>>(carts);
        }
    }
}
