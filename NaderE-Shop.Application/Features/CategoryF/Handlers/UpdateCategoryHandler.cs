using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CategoryDTO;
using NaderE_Shop.Application.Features.CategoryF.Requests;

namespace NaderE_Shop.Application.Features.CategoryF.Handlers
{
    public class UpdateCategoryHandler(ICategoryRepository repository, IMapper mapper) : IRequestHandler<UpdateCategoryRequest, Unit>
    {
        private readonly ICategoryRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetCategoryDetails(request.UpdateCategory.Id);
            _mapper.Map<UpdateCategoryDto>(category);
            await _repository.Update(category);
            return Unit.Value;
        }
    }
}
