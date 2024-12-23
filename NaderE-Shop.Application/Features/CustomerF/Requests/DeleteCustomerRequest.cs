using MediatR;

namespace NaderE_Shop.Application.Features.CustomerF.Requests
{
    public class DeleteCustomerRequest : IRequest
    {
        public int Id { get; set; }
    }
}
