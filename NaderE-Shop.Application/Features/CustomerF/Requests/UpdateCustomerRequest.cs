using MediatR;
using NaderE_Shop.Application.DTOs.CustomerDTO;

namespace NaderE_Shop.Application.Features.CustomerF.Requests
{
    public class UpdateCustomerRequest : IRequest<Unit>
    {
        public UpdateCustomerDto UpdateCustomer { get; set; }
    }
}
