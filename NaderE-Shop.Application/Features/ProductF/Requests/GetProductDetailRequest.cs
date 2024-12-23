using MediatR;
using NaderE_Shop.Application.DTOs.ProductDTO;

namespace NaderE_Shop.Application.Features.ProductF.Requests
{
    public class GetProductDetailsRequest : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
