using MediatR;
using NaderE_Shop.Application.DTOs.CategoryDTO;

namespace NaderE_Shop.Application.Features.CategoryF.Requests
{
    public class GetCategoryListRequest : IRequest<List<CategoryListDto>>
    {

    }
}
