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
    public class ContactController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    } 
}