using MediatR;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Requests
{
    public class UpdateShoppingCartRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateShoppingCartDto UpdateShoppingCart { get; set; }
        public ChangeShoppingCartStatusToPaidDto ChangeToPaid { get; set; }
    }
}
