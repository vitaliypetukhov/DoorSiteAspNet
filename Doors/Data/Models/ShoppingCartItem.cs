using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Door Door { get; set; }
        public int Ammount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
