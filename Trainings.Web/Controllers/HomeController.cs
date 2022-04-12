using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trainings.Web.Models;
using Trainings.Web.Services;

namespace Trainings.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Lessons()
        {
            var viewModel = new LessonsViewModel();
            var lessonService = new LessonService();
            var lessons = lessonService.GetAllLessons();
            viewModel.Lessons = lessons;
            return View(viewModel);
        }

        public IActionResult Lesson(int id)
        {
            var viewModel = new LessonViewModel();
            var lessonService = new LessonService();
            var currentLesson = lessonService.GetLessonById(id);
            viewModel.Lessons = lessonService.GetAllLessons();
            viewModel.Current = currentLesson;
            return View(viewModel);
        }

        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}