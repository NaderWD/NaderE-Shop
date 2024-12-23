﻿using MediatR;
using NaderE_Shop.Application.DTOs.OrderDTO;

namespace NaderE_Shop.Application.Features.OrderF.Requests
{
    public class UpdateOrderRequest : IRequest<Unit>
    {
        public UpdateOrderDto UpdateOrder { get; set; }
    }
}
