using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.ProductDTO;
using NaderE_Shop.Application.Features.ProductF.Requests;

namespace NaderE_Shop.Application.Features.ProductF.Handlers
{
    public class UpdateProductHandler(IProductRepository repository, IMapper mapper) : IRequestHandler<UpdateProductRequest, Unit>
    {
        private readonly IProductRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetProductDetails(request.UpdateProduct.Id);
            _mapper.Map<UpdateProductDto>(product);
            await _repository.Update(product);
            return Unit.Value;
        }
    }
}
