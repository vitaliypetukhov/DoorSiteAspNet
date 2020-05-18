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
    public class HomeController : Controller
    {
        private readonly IDoorRepository _doorRepository;
        public HomeController(IDoorRepository doorRepository)
        {
            _doorRepository = doorRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDoors = _doorRepository.PreferredDoors
            };

            return View(homeViewModel);
        }
    } 
}