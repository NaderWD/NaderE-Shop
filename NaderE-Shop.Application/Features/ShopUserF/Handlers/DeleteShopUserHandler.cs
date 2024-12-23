using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ShopUserF.Requests;

namespace NaderE_Shop.Application.Features.ShopUserF.Handlers
{
    public class DeleteShopUserHandler(IShopUserRepository repository) : IRequestHandler<DeleteShopUserRequest>
    {
        private readonly IShopUserRepository _repository = repository;

        public async Task Handle(DeleteShopUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetShopUserDetails(request.Id);
            if (user != null)
            {
                await _repository.Delete(user);
            }
        }
    }
}
