using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.AddressF.Requests;

namespace NaderE_Shop.Application.Features.AddressF.Handlers
{
    public class DeleteAddressHandler(IAddressRepository repository) : IRequestHandler<DeleteAddressRequest>
    {
        private readonly IAddressRepository _repository = repository;

        public async Task Handle(DeleteAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddressDetails(request.Id);
            if (address != null)
            {
                await _repository.Delete(address);
            }
        }
    }
}
