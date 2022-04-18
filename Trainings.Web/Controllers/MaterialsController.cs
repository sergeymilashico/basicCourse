using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trainings.Web.Models;
using Trainings.Web.Services;
using X.Web.Sitemap;

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

        public ContentResult SiteMap()
        {
            var sitemap = new Sitemap();
            string siteUrl = "https://milashico.com/";

            sitemap.Add(new Url
            {
                ChangeFrequency = ChangeFrequency.Daily,
                Location = siteUrl,
                Priority = 0.5,
                TimeStamp = DateTime.Now
            });

            var lessonService = new LessonService();

            sitemap.Add(CreateUrl($"{siteUrl}/Home/Index"));
            sitemap.Add(CreateUrl($"{siteUrl}Home/Schedule"));
            sitemap.Add(CreateUrl($"{siteUrl}Home/Courses"));
            sitemap.Add(CreateUrl($"{siteUrl}Home/About"));
            sitemap.Add(CreateUrl($"{siteUrl}Home/Lessons"));
            var lessons = lessonService.GetAllLessons();
            foreach(var lesson in lessons)
            {
                sitemap.Add(CreateUrl($"{siteUrl}Home/Lesson/{lesson.Id}"));
            }

            return new ContentResult
            {
                Content = sitemap.ToXml(),
                ContentType = "application/xml",
                StatusCode = 200
            };
        }

        private static Url CreateUrl(string url)
        {
            return new Url
            {
                ChangeFrequency = ChangeFrequency.Daily,
                Location = url,
                Priority = 0.5,
                TimeStamp = DateTime.Now
            };
        }
    }
}