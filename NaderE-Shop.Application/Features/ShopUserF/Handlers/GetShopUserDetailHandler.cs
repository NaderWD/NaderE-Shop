using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ShopUserDTO;
using NaderE_Shop.Application.Features.ShopUserF.Requests;

namespace NaderE_Shop.Application.Features.ShopUserF.Handlers
{
    public class GetShopUserDetailsHandler(IShopUserRepository repository, IMapper mapper) : IRequestHandler<GetShopUserDetailsRequest, ShopUserDto>
    {
        private readonly IShopUserRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<ShopUserDto> Handle(GetShopUserDetailsRequest request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetShopUserDetails(request.Id);
            return _mapper.Map<ShopUserDto>(user);
        }
    }
}
