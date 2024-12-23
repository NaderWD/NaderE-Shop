using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.AddressDTO;
using NaderE_Shop.Application.Features.AddressF.Requests;

namespace NaderE_Shop.Application.Features.AddressF.Handlers
{
    public class UpdateAddressHandler(IAddressRepository repository, IMapper mapper) : IRequestHandler<UpdateAddressRequest, Unit>
    {
        private readonly IAddressRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _repository.GetAddressDetails(request.UpdateAddress.Id);
            _mapper.Map<UpdateAddressDto>(address);
            await _repository.Update(address);
            return Unit.Value;
        }
    }
}
