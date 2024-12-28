using AutoMapper;
using MediatR;
using NaderE_Shop.Application.Contracts.InfrastructureCont;
using NaderE_Shop.Application.Contracts.PersistenceCont;
using NaderE_Shop.Application.Features.ShoppingCartF.Requests;
using NaderE_Shop.Application.OtherModels.Email;
using NaderE_Shop.Domain.Models;

namespace NaderE_Shop.Application.Features.ShoppingCartF.Handlers
{
    public class CreateShoppingCartHandler(IShoppingCartRepository repository, IMapper mapper
                                            /*, IEmailSender emailSender */) : IRequestHandler<CreateShoppingCartRequest, int>
    {
        private readonly IShoppingCartRepository _repository = repository;
        private readonly IMapper _mapper = mapper;
        //private readonly IEmailSender _emailSender = emailSender;

        public async Task<int> Handle(CreateShoppingCartRequest request, CancellationToken cancellationToken)
        {
            var cart = _mapper.Map<ShoppingCart>(request.CreateShoppingCart);
            await _repository.Add(cart);

            //var email = new Email
            //{
            //    To = "Customer@gmail.com",
            //    Subject = "Shopping Cart Creation",
            //    Body = $"Your New Shopping Cart Has Been Created in {request.CreateShoppingCart.AddedDate}",
            //};
            //try
            //{
            //    await _emailSender.SendEmail(email);
            //}
            //catch (Exception)
            //{
            //    //log
            //}

            return cart.Id;

        }
    }
}
