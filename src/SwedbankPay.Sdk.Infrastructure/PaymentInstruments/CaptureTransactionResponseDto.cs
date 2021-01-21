﻿using SwedbankPay.Sdk.PaymentInstruments.Card;
using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments
{
    internal class CaptureTransactionResponseDto
    {
        public Uri Id { get; set; }
        public string Payment { get; set; }
        public TransactionDto Capture { get; set; }

        internal ICapturesList Map()
        {
            var transactionList = new List<ITransaction>();
            if(Capture != null) {
                transactionList.Add(Capture.Map());
            }
            return new CapturesList(Id, transactionList);
        }
    }

}