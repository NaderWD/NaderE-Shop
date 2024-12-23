using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ProductDTO;
using NaderE_Shop.Application.Features.ProductF.Requests;

namespace NaderE_Shop.Application.Features.ProductF.Handlers
{
    public class GetProductDetailsHandler(IProductRepository repository, IMapper mapper) : IRequestHandler<GetProductDetailsRequest, ProductDto>
    {
        private readonly IProductRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<ProductDto> Handle(GetProductDetailsRequest request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetProductDetails(request.Id);
            return _mapper.Map<ProductDto>(product);
        }
    }
}
