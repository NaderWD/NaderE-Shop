using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Handlers
{
    public class UpdateShoppingCartHandler(IShoppingCartRepository repository, IMapper mapper) : IRequestHandler<UpdateShoppingCartRequest, Unit>
    {
        private readonly IShoppingCartRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateShoppingCartRequest request, CancellationToken cancellationToken)
        {
            var cart = await _repository.GetShoppingCartDetails(request.Id);
            if (request.UpdateShoppingCart != null)
            {
                _mapper.Map<UpdateShoppingCartDto>(cart);
                await _repository.Update(cart);
            }
            else if (request.ChangeToPaid != null)
            {
                await _repository.ChangeStatusToPaid(cart, request.ChangeToPaid.IsPaid == true);
            }

            return Unit.Value;
        }
    }
}
