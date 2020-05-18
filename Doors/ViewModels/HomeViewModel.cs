using Doors.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable <Door> PreferredDoors { get; set; }
    }
}
