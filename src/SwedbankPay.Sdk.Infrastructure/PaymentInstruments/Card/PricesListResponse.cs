﻿using SwedbankPay.Sdk.Common;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments.Card
{
    public class PricesListResponse : IdLink, IPricesListResponse
    {
        public PricesListResponse(List<IPrice> priceList)
        {
            PriceList = priceList;
        }


        public List<IPrice> PriceList { get; }
    }
}