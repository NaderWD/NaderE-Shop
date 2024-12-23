using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.OrderF.Requests;

namespace NaderE_Shop.Application.Features.OrderF.Handlers
{
    public class DeleteOrderHandler(IOrderRepository repository) : IRequestHandler<DeleteOrderRequest>
    {
        private readonly IOrderRepository _repository = repository;

        public async Task Handle(DeleteOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetOrderDetails(request.Id);
            if (order != null)
            {
                await _repository.Delete(order);
            }
        }
    }
}
