using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trainings.Web.Models;
using Trainings.Web.Services;

namespace Trainings.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        public IActionResult About_Speciality_RU()
        {
            return View();
        }

    }
}