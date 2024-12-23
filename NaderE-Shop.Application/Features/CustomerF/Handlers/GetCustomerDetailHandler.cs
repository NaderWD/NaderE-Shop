using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CustomerDTO;
using NaderE_Shop.Application.Features.CustomerF.Requests;

namespace NaderE_Shop.Application.Features.CustomerF.Handlers
{
    public class GetCustomerDetailHandler(ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetCustomerDetailRequest, CustomerDto>
    {
        private readonly ICustomerRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<CustomerDto> Handle(GetCustomerDetailRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetCustomerDetails(request.Id);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
