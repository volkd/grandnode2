﻿using Grand.Domain.Payments;
using MediatR;

namespace Grand.Business.Checkout.Commands.Models.Orders
{
    public class VoidOfflineCommand : IRequest<bool>
    {
        public PaymentTransaction PaymentTransaction { get; set; }
    }
}
