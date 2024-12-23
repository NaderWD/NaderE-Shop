using MediatR;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Requests
{
    public class GetShoppingCartDetailsRequest : IRequest<ShoppingCartDto>
    {
        public int Id { get; set; }
    }
}
