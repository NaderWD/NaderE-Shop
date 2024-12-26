using MediatR;
using NaderE_Shop.Application.DTOs.AddressDTO;

namespace NaderE_Shop.Application.Features.AddressF.Requests
{
    public class UpdateAddressRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateAddressDto UpdateAddress { get; set; }
    }
}
