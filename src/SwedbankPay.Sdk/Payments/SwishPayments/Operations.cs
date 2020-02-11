﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwedbankPay.Sdk.Payments.SwishPayments
{
    public class Operations : Dictionary<LinkRelation, HttpOperation>
    {
        public Func<Task<PaymentResponse>> Abort { get; internal set; }
        public Func<ReversalRequest, Task<ReversalResponse>> Reversal { get; internal set; }
        public Func<SaleRequest, Task<SaleResponse>> Sale { get; internal set; }
        public new HttpOperation this[LinkRelation rel] => ContainsKey(rel) ? base[rel] : null;
        public HttpOperation PaidPayment { get; internal set; }
        public HttpOperation RedirectSale { get; internal set; }
        public HttpOperation ViewSales { get; internal set; }
    }
}