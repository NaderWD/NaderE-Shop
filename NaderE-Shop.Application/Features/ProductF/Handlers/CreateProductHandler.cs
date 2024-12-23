using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ProductF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.ProductF.Handlers
{
    public class CreateProductHandler(IProductRepository repository, IMapper mapper) : IRequestHandler<CreateProductRequest, int>
    {
        private readonly IProductRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.CreateProduct);
            await _repository.Add(product);
            return product.Id;
        }
    }
}
