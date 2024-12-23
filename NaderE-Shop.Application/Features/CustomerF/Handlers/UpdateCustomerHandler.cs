using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.DTOs.CustomerDTO;
using NaderE_Shop.Application.Features.CustomerF.Requests;

namespace NaderE_Shop.Application.Features.CustomerF.Handlers
{
    public class UpdateCustomerHandler(ICustomerRepository repository, IMapper mapper) : IRequestHandler<UpdateCustomerRequest, Unit>
    {
        private readonly ICustomerRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<Unit> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetCustomerDetails(request.UpdateCustomer.Id);
            _mapper.Map<UpdateCustomerDto>(customer);
            await _repository.Update(customer);
            return Unit.Value;
        }
    }
}
