using Trainings.Web.Models;

namespace Trainings.Web.Services
{
    public class LessonService
    {
        public List<Lesson> GetAllLessons()
        {
            List<Lesson> result = new List<Lesson>();

            result.Add(new Lesson
            {
                Id = 1,
                Name = "Введение в спеиальность",
                Description = "Введение в спеиальность",
                CodeLink = null,
                VideoLink = "https://www.youtube.com/embed/1dFm8aRkyVw"
            });

            result.Add(new Lesson
            {
                Id = 2,
                Name = "Создание сайтов",
                Description = "Создание сайтов с помощью Balsamiq и Bootstrap",
                CodeLink = "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson3_WebSite",
                VideoLink = "https://www.youtube.com/embed/gAYBYPjuYeQ"
            });

            result.Add(new Lesson
            {
                Id = 3,
                Name = "Языки программирования",
                Description = "Языки программирования, история C#, Типы",
                CodeLink = null,
                VideoLink = "https://www.youtube.com/embed/IWPIr9GRiFo"
            });

            return result;
        }

        public Lesson GetLessonById(int id)
        {
            var result = GetAllLessons().FirstOrDefault(lesson => lesson.Id == id);
            return result;
        }
    }
}
