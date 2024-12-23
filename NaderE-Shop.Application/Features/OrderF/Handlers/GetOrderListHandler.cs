using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.OrderDTO;
using NaderE_Shop.Application.Features.OrderF.Requests;

namespace NaderE_Shop.Application.Features.OrderF.Handlers
{
    public class GetOrderListHandler(IOrderRepository repository, IMapper mapper) : IRequestHandler<GetOrderListRequest, List<OrderListDto>>
    {
        private readonly IOrderRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<OrderListDto>> Handle(GetOrderListRequest request, CancellationToken cancellationToken)
        {
            var orders = await _repository.GetAllOrders();
            return _mapper.Map<List<OrderListDto>>(orders);
        }
    }
}
