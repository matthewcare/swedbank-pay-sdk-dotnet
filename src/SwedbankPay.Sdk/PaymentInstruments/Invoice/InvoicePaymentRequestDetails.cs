﻿using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments.Invoice
{
    /// <summary>
    /// Object containing detailed information about a invoice payment.
    /// </summary>
    public class InvoicePaymentRequestDetails : IPaymentRequestDetails
    {
        /// <summary>
        /// Instantiates a <see cref="InvoicePaymentRequestDetails"/> with the provided parameters.
        /// </summary>
        /// <param name="operation">The initial API operation for this invoice request.</param>
        /// <param name="intent">The initial payment intent for this invoice.</param>
        /// <param name="currency">The <seealso cref="Currency"/> this payment will be paid in.</param>
        /// <param name="description">A textual description of what is being paid.</param>
        /// <param name="userAgent">The payers UserAgent string.</param>
        /// <param name="language">The payers prefered <seealso cref="Sdk.Language"/>.</param>
        /// <param name="urls">Object containing relevant URLs for this payment.</param>
        /// <param name="payeeInfo">Object with merchant information.</param>
        public InvoicePaymentRequestDetails(Operation operation,
                                                    PaymentIntent intent,
                                                    Currency currency,
                                                    string description,
                                                    string userAgent,
                                                    Language language,
                                                    IUrls urls,
                                                    PayeeInfo payeeInfo)
        {
            Operation = operation ?? throw new ArgumentNullException(nameof(operation));
            Intent = intent;
            Currency = currency;
            Description = description;
            UserAgent = userAgent;
            Language = language;
            Urls = urls;
            PayeeInfo = payeeInfo;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool GeneratePaymentToken { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool GenerateRecurrenceToken { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public PaymentIntent Intent { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Operation Operation { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public PayeeInfo PayeeInfo { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string PayerReference { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string PaymentToken { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<IPrice> Prices { get; set; } = new List<IPrice>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IUrls Urls { get; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public PrefillInfo PrefillInfo { get; set; }
    }

}