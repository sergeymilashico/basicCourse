using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trainings.Web.Models;
using Trainings.Web.Services;

namespace Trainings.Web.Controllers
{
    public class MaterialsController : Controller
    {
        private readonly ILogger<MaterialsController> _logger;

        public MaterialsController(ILogger<MaterialsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Homework(int courseId, int lessonId)
        {
            return View();
        }

        public IActionResult Readings(int courseId, int lessonId)
        {
            return View();
        }

    }
}