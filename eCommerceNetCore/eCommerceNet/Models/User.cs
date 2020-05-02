using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceNet.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Shipping_Address { get; set; }
        public string Billing_Address { get; set; }
        public string Purchase_History { get; set; }

    }
}
