using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trainings.Web.Models;
using Trainings.Web.Services;

namespace Trainings.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
        }

        public IActionResult Subscribe()
        {
            return View();
        }

    }
}