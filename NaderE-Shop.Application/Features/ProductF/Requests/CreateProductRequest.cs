using MediatR;
using NaderE_Shop.Application.DTOs.ProductDTO;

namespace NaderE_Shop.Application.Features.ProductF.Requests
{
    public class CreateProductRequest : IRequest<int>
    {
        public CreateProductDto CreateProduct { get; set; }
    }
}
