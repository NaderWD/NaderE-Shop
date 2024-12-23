using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.AddressF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.AddressF.Handlers
{
    public class CreateAddressHandler(IAddressRepository repository, IMapper mapper) : IRequestHandler<CreateAddressRequest, int>
    {
        private readonly IAddressRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateAddressRequest request, CancellationToken cancellationToken)
        {
            var address = _mapper.Map<Address>(request.CreateAddress);
            await _repository.Add(address);
            return address.Id;
        }
    }
}
