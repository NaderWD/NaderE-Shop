using MediatR;
using NaderE_Shop.Application.DTOs.CustomerDTO;

namespace NaderE_Shop.Application.Features.CustomerF.Requests
{
    public class GetCustomerDetailRequest : IRequest<CustomerDto>
    {
        public int Id { get; set; }
    }
}
