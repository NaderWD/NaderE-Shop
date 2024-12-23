using MediatR;

namespace NaderE_Shop.Application.Features.ShopUserF.Requests
{
    public class DeleteShopUserRequest : IRequest
    {
        public int Id { get; set; }
    }
}
