using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ShopUserDTO;
using NaderE_Shop.Application.Features.ShopUserF.Requests;

namespace NaderE_Shop.Application.Features.ShopUserF.Handlers
{
    public class UpdateShopUserHandler(IShopUserRepository repository, IMapper mapper) : IRequestHandler<UpdateShopUserRequest, Unit>
    {
        private readonly IShopUserRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateShopUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetShopUserDetails(request.UpdateShopUser.Id);
            _mapper.Map<UpdateShopUserDto>(user);
            await _repository.Update(user);
            return Unit.Value;
        }
    }
}
