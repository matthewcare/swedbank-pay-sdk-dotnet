﻿namespace Sample.AspNetCore.SystemTests.Test.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderItem
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }
        public double Quantity { get; set; }
    }
}
