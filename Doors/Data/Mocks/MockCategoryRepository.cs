using Doors.Data.Interfaces;
using Doors.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doors.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories { 
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "InputDoors", Description = "All input doors"},
                    new Category {CategoryName ="InteriorDoors", Description = "All interior doors"}
                };
            }
        } 
    }
}
