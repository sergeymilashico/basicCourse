using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using Trainings.Web.Models;
using Trainings.Web.Services;

namespace Trainings.Web.Controllers
{
    [Internationalization]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IStringLocalizer<HomeController> _stringLocalizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> stringLocalizer)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetCulture(string id = "en")
        {
            string culture = id;
            Response.Cookies.Append(
               CookieRequestCultureProvider.DefaultCookieName,
               CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
               new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
           );

            ViewData["Message"] = "Culture set to " + culture;

            return View("About");
        }

        //[HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
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
            var viewModel = new LessonsViewModel();
            var lessonService = new LessonService();
            var lessons = lessonService.GetAllLessons();
            viewModel.Lessons = lessons;
            return View(viewModel);
        }

        public IActionResult About()
        {
            string message = _stringLocalizer["AboutUs"].Value;
            ViewData["Title"] = message;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}