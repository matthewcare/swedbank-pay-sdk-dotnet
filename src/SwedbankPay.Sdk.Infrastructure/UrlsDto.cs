﻿using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk
{
    public class UrlsDto
    {
        public Uri Id { get; set; }
        public string CallbackUrl { get; set; }

        public string CancelUrl { get; set; }

        public string CompleteUrl { get; set; }

        public ICollection<Uri> HostUrls { get; set; }

        public string LogoUrl { get; set; }

        public string PaymentUrl { get; set; }

        public string TermsOfServiceUrl { get; set; }

        internal IUrls Map()
        {
            if (HostUrls == null)
            {
                return new IdLink() { Id = Id } as IUrls;
            }

            return new Urls(this);
        }
    }
}