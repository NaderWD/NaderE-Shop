using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.CustomerF.Requests;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.CustomerF.Handlers
{
    public class CreateCustomerHandler(ICustomerRepository repository, IMapper mapper) : IRequestHandler<CreateCustomerRequest, int>
    {
        private readonly ICustomerRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request.CreateCustomer);
            await _repository.Add(customer);
            return customer.Id;
        }
    }
}
