using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.CustomerF.Requests;

namespace NaderE_Shop.Application.Features.CustomerF.Handlers
{
    public class DeleteCustomerHandler(ICustomerRepository repository) : IRequestHandler<DeleteCustomerRequest>
    {
        private readonly ICustomerRepository _repository = repository;

        public async Task Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetCustomerDetails(request.Id);
            if (customer != null)
            {
                await _repository.Delete(customer);
            }
        }
    }
}
