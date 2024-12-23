using MediatR;

namespace NaderE_Shop.Application.Features.ProductF.Requests
{
    public class DeleteProductRequest : IRequest
    {
        public int Id { get; set; }
    }
}
