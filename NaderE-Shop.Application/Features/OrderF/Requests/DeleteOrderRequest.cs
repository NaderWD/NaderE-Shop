using MediatR;

namespace NaderE_Shop.Application.Features.OrderF.Requests
{
    public class DeleteOrderRequest : IRequest
    {
        public int Id { get; set; }
    }
}
