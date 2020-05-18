using Doors.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.Data.Interfaces
{
    public interface IDoorRepository
    {
        IEnumerable<Door> Doors { get;  }
        IEnumerable<Door> PreferredDoors { get;  }
        Door GetDoorById(int doorId);
    }
}
