using MediatR;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Requests
{
    public class DeleteShoppingCartRequest : IRequest
    {
        public int Id { get; set; }
    }
}
