using MediatR;
using NaderE_Shop.Application.DTOs.AddressDTO;

namespace NaderE_Shop.Application.Features.AddressF.Requests
{
    public class GetAddressListRequest : IRequest<List<AddressListDto>>
    {

    }
}
