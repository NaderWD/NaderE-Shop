using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.CategoryF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.CategoryF.Handlers
{
    public class CreateCategoryHandler(ICategoryRepository repository, IMapper mapper) : IRequestHandler<CreateCategoryRequest, int> 
    {
        private readonly ICategoryRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request.CreateCategory);
            await _repository.Add(category);
            return category.Id;
        }
    }
}
