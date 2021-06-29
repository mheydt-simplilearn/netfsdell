using EHealth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.User.Web.Models
{
    public class CartItem
    {
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
    }
}
