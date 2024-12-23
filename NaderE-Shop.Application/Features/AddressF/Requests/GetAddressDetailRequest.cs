using MediatR;
using NaderE_Shop.Application.DTOs.AddressDTO;

namespace NaderE_Shop.Application.Features.AddressF.Requests
{
    public class GetAddressDetailsRequest : IRequest<AddressDto>
    {
        public int Id { get; set; }
    }
}
