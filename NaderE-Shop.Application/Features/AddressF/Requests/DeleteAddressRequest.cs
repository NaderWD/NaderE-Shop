using MediatR;

namespace NaderE_Shop.Application.Features.AddressF.Requests
{
    public class DeleteAddressRequest : IRequest
    {
        public int Id { get; set; }
    }
}
