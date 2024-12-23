using MediatR;
using NaderE_Shop.Application.DTOs.ShopUserDTO;

namespace NaderE_Shop.Application.Features.ShopUserF.Requests
{
    public class GetShopUsersListRequest : IRequest<List<ShopUserListDto>>
    {

    }
}
