using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.ViewModels
{
    public class DoorViewModel
    {
        public int DoorId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}
