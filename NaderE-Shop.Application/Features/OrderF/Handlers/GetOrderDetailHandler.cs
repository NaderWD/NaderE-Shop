using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.OrderDTO;
using NaderE_Shop.Application.Features.OrderF.Requests;

namespace NaderE_Shop.Application.Features.OrderF.Handlers
{
    public class GetOrderDetailHandler(IOrderRepository repository, IMapper mapper) : IRequestHandler<GetOrderDetailRequest, OrderDto>
    {
        private readonly IOrderRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<OrderDto> Handle(GetOrderDetailRequest request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetOrderDetails(request.Id);
            return _mapper.Map<OrderDto>(order);
        }
    }
}
