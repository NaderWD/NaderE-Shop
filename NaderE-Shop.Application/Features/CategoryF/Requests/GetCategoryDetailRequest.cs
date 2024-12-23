using MediatR;
using NaderE_Shop.Application.DTOs.CategoryDTO;

namespace NaderE_Shop.Application.Features.CategoryF.Requests
{
    public class GetCategoryDetailRequest : IRequest<CategoryDto>
    {
        public int Id { get; set; }
    }
}
