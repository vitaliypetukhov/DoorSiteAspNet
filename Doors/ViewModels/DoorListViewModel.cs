using Doors.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.ViewModels
{
    public class DoorListViewModel
    {
        public IEnumerable<Door> Doors { get; set; }
        public string CurrentCategory { get; set; }
    }
}
