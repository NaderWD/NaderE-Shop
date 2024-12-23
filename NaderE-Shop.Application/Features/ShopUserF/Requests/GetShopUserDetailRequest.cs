using MediatR;
using NaderE_Shop.Application.DTOs.ShopUserDTO;

namespace NaderE_Shop.Application.Features.ShopUserF.Requests
{
    public class GetShopUserDetailsRequest : IRequest<ShopUserDto>
    {
        public int Id { get; set; }
    }
}
