using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CategoryDTO;
using NaderE_Shop.Application.Features.CategoryF.Requests;

namespace NaderE_Shop.Application.Features.CategoryF.Handlers
{
    public class GetCategoryListHandler(ICategoryRepository repository, IMapper mapper) :
        IRequestHandler<GetCategoryListRequest, List<CategoryListDto>>
    {
        private readonly ICategoryRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<CategoryListDto>> Handle(GetCategoryListRequest request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllCategories();
            return _mapper.Map<List<CategoryListDto>>(categories);
        }
    }
}
