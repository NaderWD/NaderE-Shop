using MediatR;
using NaderE_Shop.Application.DTOs.ProductDTO;

namespace NaderE_Shop.Application.Features.ProductF.Requests
{
    public class GetProductsListRequest : IRequest<List<ProductListDto>>
    {

    }
}
