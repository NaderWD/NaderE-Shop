using MediatR;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Requests
{
    public class CreateShoppingCartRequest : IRequest<int>
    {
        public CreateShoppingCartDto CreateShoppingCart { get; set; }
    }
}
