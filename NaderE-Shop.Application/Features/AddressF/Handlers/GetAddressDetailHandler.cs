using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.AddressDTO;
using NaderE_Shop.Application.Features.AddressF.Requests;

namespace NaderE_Shop.Application.Features.AddressF.Handlers
{
    public class GetAddressDetailsHandler(IAddressRepository repository, IMapper mapper) : IRequestHandler<GetAddressDetailsRequest, AddressDto>
    {
        private readonly IAddressRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<AddressDto> Handle(GetAddressDetailsRequest request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddressDetails(request.Id);
            return _mapper.Map<AddressDto>(address);
        }
    }
}
