using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.AddressDTO;
using NaderE_Shop.Application.Features.AddressF.Requests;

namespace NaderE_Shop.Application.Features.AddressF.Handlers
{
    public class GetAddressListHandler(IAddressRepository repository, IMapper mapper) : IRequestHandler<GetAddressListRequest, List<AddressListDto>>
    {
        private readonly IAddressRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<AddressListDto>> Handle(GetAddressListRequest request, CancellationToken cancellationToken)
        {
            var addresses = await _repository.GetAllAddresses();
            return _mapper.Map<List<AddressListDto>>(addresses);
        }
    }
}
