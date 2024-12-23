using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Handlers
{
    public class GetShoppingCartDetailsHandler(IShoppingCartRepository repository, IMapper mapper) : IRequestHandler<GetShoppingCartDetailsRequest, ShoppingCartDto>
    {
        private readonly IShoppingCartRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<ShoppingCartDto> Handle(GetShoppingCartDetailsRequest request, CancellationToken cancellationToken)
        {
            var cart = await _repository.GetShoppingCartDetails(request.Id);
            return _mapper.Map<ShoppingCartDto>(cart);
        }
    }
}
