using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doors.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How?";
            
            DoorListViewModel vm = new DoorListViewModel();
            vm.Doors = _doorRepository.Doors;
            vm.CurrentCategory = "DoorCategory";

            return View(vm);
        }
    }
}