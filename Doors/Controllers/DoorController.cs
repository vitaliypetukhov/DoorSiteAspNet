using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doors.Data.Interfaces;
using Doors.Data.Models;
using Doors.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doors.Controllers
{
    public class DoorController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDoorRepository _doorRepository;
        public DoorController(ICategoryRepository categoryRepository, IDoorRepository doorRepository)
        {
            _categoryRepository = categoryRepository;
            _doorRepository = doorRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Door> doors;

            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                doors = _doorRepository.Doors.OrderBy(n => n.DoorId);
                currentCategory = "All Doors";
            }
            else
            {
                if(string.Equals("InteriorDoors",_category, StringComparison.OrdinalIgnoreCase))
                {
                    doors = _doorRepository.Doors.Where(p => p.Category.CategoryName.Equals("InteriorDoors")).OrderBy(p => p.Name);
                }
                else
                {
                    doors = _doorRepository.Doors.Where(p => p.Category.CategoryName.Equals("InputDoors")).OrderBy(p => p.Name);
                }

                currentCategory = _category;
            }

            var doorListViewModel = new DoorListViewModel
            {
                Doors = doors,
                CurrentCategory = currentCategory
            };

            return View(doorListViewModel);
        }
    }
}