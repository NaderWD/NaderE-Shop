using MediatR;
using NaderE_Shop.Application.DTOs.AddressDTO;

namespace NaderE_Shop.Application.Features.AddressF.Requests
{
    public class CreateAddressRequest : IRequest<int>
    {
        public CreateAddressDto CreateAddress { get; set; }
    }
}
