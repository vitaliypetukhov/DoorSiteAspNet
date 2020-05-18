using Doors.Data.Interfaces;
using Doors.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.Data.Repositories
{
    public class DoorRepository : IDoorRepository
    {
        private readonly AppDbContext _appDbContext;
        public DoorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Door> Doors => _appDbContext.Doors.Include(c => c.Category);

        public IEnumerable<Door> PreferredDoors => _appDbContext.Doors.Where(p => p.IsPreferredDoor).Include(c => c.Category);

        public Door GetDoorById(int doorId) => _appDbContext.Doors.FirstOrDefault(p => p.DoorId == doorId);
        
    }
}
