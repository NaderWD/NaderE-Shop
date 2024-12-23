using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ProductDTO;
using NaderE_Shop.Application.Features.ProductF.Requests;

namespace NaderE_Shop.Application.Features.ProductF.Handlers
{
    public class GetProductsListHandler(IProductRepository repository, IMapper mapper) : IRequestHandler<GetProductsListRequest, List<ProductListDto>>
    {
        private readonly IProductRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<ProductListDto>> Handle(GetProductsListRequest request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllProducts();
            return _mapper.Map<List<ProductListDto>>(products);
        }
    }
}
