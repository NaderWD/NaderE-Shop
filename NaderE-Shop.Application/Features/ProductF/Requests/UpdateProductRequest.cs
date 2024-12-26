using MediatR;
using NaderE_Shop.Application.DTOs.ProductDTO;

namespace NaderE_Shop.Application.Features.ProductF.Requests
{
    public class UpdateProductRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateProductDto UpdateProduct { get; set; }
    }
}
