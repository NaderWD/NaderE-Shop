using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ShopUserF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.ShopUserF.Handlers
{
    public class CreateShopUserHandler(IShopUserRepository repository, IMapper mapper) : IRequestHandler<CreateShopUserRequest, int>
    {
        private readonly IShopUserRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateShopUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<ShopUser>(request.CreateShopUser);
            await _repository.Add(user);
            return user.Id;
        }
    }
}
