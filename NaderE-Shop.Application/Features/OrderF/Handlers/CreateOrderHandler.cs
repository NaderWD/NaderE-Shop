using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.OrderF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.OrderF.Handlers
{
    public class CreateOrderHandler(IOrderRepository repository, IMapper mapper) : IRequestHandler<CreateOrderRequest, int>
    {
        private readonly IOrderRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request.CreateOrder);
            await _repository.Add(order);
            return order.Id;
        }
    }
}
