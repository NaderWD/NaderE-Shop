using MediatR;

namespace NaderE_Shop.Application.Features.CategoryF.Requests
{
    public class DeleteCategoryRequest : IRequest
    {
        public int Id { get; set; }
    }
}
