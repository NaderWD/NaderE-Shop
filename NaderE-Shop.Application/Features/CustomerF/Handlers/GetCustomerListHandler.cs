using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CustomerDTO;
using NaderE_Shop.Application.Features.CustomerF.Requests;

namespace NaderE_Shop.Application.Features.CustomerF.Handlers
{
    public class GetCustomerListHandler(ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetCustomerListRequest, List<CustomerListDto>>
    {
        private readonly ICustomerRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<CustomerListDto>> Handle(GetCustomerListRequest request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetAllCustomers();
            return _mapper.Map<List<CustomerListDto>>(customers);
        }
    }
}
