using MediatR;
using NaderE_Shop.Application.DTOs.OrderDTO;

namespace NaderE_Shop.Application.Features.OrderF.Requests
{
    public class CreateOrderRequest : IRequest<int>
    {
        public CreateOrderDto CreateOrder { get; set; }
    }
}
