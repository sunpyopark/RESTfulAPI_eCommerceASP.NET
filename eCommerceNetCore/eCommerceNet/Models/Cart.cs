﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceNet.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity  { get; set; }
    }
}
