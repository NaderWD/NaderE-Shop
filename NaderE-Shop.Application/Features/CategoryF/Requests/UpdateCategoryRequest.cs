using MediatR;
using NaderE_Shop.Application.DTOs.CategoryDTO;

namespace NaderE_Shop.Application.Features.CategoryF.Requests
{
    public class UpdateCategoryRequest : IRequest<Unit>
    {
        public UpdateCategoryDto UpdateCategory { get; set; }
    }
}
