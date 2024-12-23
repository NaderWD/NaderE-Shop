using MediatR;
using NaderE_Shop.Application.DTOs.OrderDTO;

namespace NaderE_Shop.Application.Features.OrderF.Requests
{
    public class GetOrderDetailRequest : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
