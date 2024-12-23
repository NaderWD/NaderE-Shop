using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ShopUserDTO;
using NaderE_Shop.Application.Features.ShopUserF.Requests;

namespace NaderE_Shop.Application.Features.ShopUserF.Handlers
{
    public class GetShopUsersListHandler(IShopUserRepository repository, IMapper mapper) : IRequestHandler<GetShopUsersListRequest, List<ShopUserListDto>>
    {
        private readonly IShopUserRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<ShopUserListDto>> Handle(GetShopUsersListRequest request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllShopUsers();
            return _mapper.Map<List<ShopUserListDto>>(users);
        }
    }
}
