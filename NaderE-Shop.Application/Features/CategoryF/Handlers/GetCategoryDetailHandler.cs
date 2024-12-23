using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CategoryDTO;
using NaderE_Shop.Application.Features.CategoryF.Requests;

namespace NaderE_Shop.Application.Features.CategoryF.Handlers
{
    public class GetCategoryDetailHandler(ICategoryRepository repository, IMapper mapper) : IRequestHandler<GetCategoryDetailRequest, CategoryDto>
    {
        private readonly ICategoryRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<CategoryDto> Handle(GetCategoryDetailRequest request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetCategoryDetails(request.Id);
            return _mapper.Map<CategoryDto>(category);
        }
    }
}
