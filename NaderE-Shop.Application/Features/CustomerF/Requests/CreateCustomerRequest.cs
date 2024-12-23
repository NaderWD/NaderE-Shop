using MediatR;
using NaderE_Shop.Application.DTOs.CustomerDTO;

namespace NaderE_Shop.Application.Features.CustomerF.Requests
{
    public class CreateCustomerRequest : IRequest<int>
    {
        public CreateCustomerDto CreateCustomer { get; set; }
    }
}
