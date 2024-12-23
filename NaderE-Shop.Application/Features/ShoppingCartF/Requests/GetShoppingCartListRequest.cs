using MediatR;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Requests
{
    public class GetShoppingCartsListRequest : IRequest<List<ShoppingCartListDto>>
    {

    }
}
