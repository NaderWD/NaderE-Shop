using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.OrderDTO;
using NaderE_Shop.Application.Features.OrderF.Requests;

namespace NaderE_Shop.Application.Features.OrderF.Handlers
{
    public class UpdateOrderHandler(IOrderRepository repository, IMapper mapper) : IRequestHandler<UpdateOrderRequest, Unit>
    {
        private readonly IOrderRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetOrderDetails(request.UpdateOrder.Id);
            _mapper.Map<UpdateOrderDto>(order);
            await _repository.Update(order);
            return Unit.Value;
        }
    }
}
