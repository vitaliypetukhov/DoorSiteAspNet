using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DoorId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Door Door { get; set; }
        public virtual Order Order { get; set; }
    }
}
