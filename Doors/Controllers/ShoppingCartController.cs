using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doors.Data.Interfaces;
using Doors.Data.Models;
using Doors.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Doors.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDoorRepository _doorRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IDoorRepository doorRepository, ShoppingCart shoppingCart)
        {
            _doorRepository = doorRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;


            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(sCVM); 
        }

        public RedirectToActionResult AddToShoppingCart(int doorId)
        {
            var selectedDoor = _doorRepository.Doors.FirstOrDefault(p => p.DoorId == doorId);
            if (selectedDoor != null)
            {
                _shoppingCart.AddToCart(selectedDoor, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int doorId)
        {
            var selectedDoor = _doorRepository.Doors.FirstOrDefault(p => p.DoorId == doorId);
            if (selectedDoor != null)
            {
                _shoppingCart.RemoveFromCart(selectedDoor);
            }
            return RedirectToAction("Index");
        }
    }
}