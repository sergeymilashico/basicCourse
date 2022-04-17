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
                Name = "Введение в специальность",
                Description = "Введение в специальность",
                CodeLink = null,
                VideoLink = "https://www.youtube.com/embed/1dFm8aRkyVw"
            });

            result.Add(new Lesson
            {
                Id = 2,
                Name = "Создание сайтов",
                Description = "Создание сайтов с помощью Balsamiq и Bootstrap",
                CodeLink = "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson3_WebSite",
                VideoLink = "https://www.youtube.com/embed/gAYBYPjuYeQ",
                PresentationLink = "https://docs.google.com/document/d/1tFqw-qKREnsh9vw04aSqRGHiy2zHok-4/",
                HomeworkLink = "https://docs.google.com/document/d/1Ja_-Xm_bp8acHsEgyW_F0iRjCk_gdHaN1Rvw6WK6VhY/"
            }) ;

            result.Add(new Lesson
            {
                Id = 3,
                Name = "Языки программирования",
                Description = "Языки программирования, история C#, Типы",
                CodeLink = null,
                PresentationLink= "https://docs.google.com/document/d/1Oo-xFjrBTRgZJy3Dhi53NJN2wqg061vW/",
                HomeworkLink= "https://docs.google.com/document/d/1BKNGM6YlzMnnnm__1CDrxCJNBMaDFWC0dxXbSoEbAmc/",
                VideoLink = "https://www.youtube.com/embed/IWPIr9GRiFo"
            });

            result.Add(new Lesson
            {
                Id = 4,
                Name = "GitHub, VS Code, Первая программа",
                Description = "GitHub, VS Code, Первая программа",
                CodeLink = null,
                PresentationLink = "https://docs.google.com/document/d/1Oo-xFjrBTRgZJy3Dhi53NJN2wqg061vW/",
                HomeworkLink = "https://docs.google.com/document/d/1BKNGM6YlzMnnnm__1CDrxCJNBMaDFWC0dxXbSoEbAmc/",
                VideoLink = "https://www.youtube.com/embed/I47EwlCj3ZE"
            });

            result.Add(new Lesson
            {
                Id = 5,
                Name = "Синтаксис языка C#. 1 Часть",
                Description = "Синтаксис языка C#. 1 Часть",
                CodeLink = "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson5_Basics",
                VideoLink = "https://www.youtube.com/embed/jZCb1tYESD4",
                HomeworkLink = "https://docs.google.com/document/d/1MguH6immkhXPz3tOV1SxtzUTKAAUx7Hti44UnIMwkQA/"
            });

            result.Add(new Lesson
            {
                Id = 6,
                Name = "Синтаксис языка C#. 2 Часть",
                Description = "Синтаксис языка C#. 2 Часть",
                CodeLink = "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson6_Loops",
                VideoLink = "https://www.youtube.com/embed/P97QTKisSRg",
                HomeworkLink = "https://docs.google.com/document/d/1MguH6immkhXPz3tOV1SxtzUTKAAUx7Hti44UnIMwkQA/"
            });

            result.Add(new Lesson
            {
                Id = 7,
                Name = "Практика C#. Введение, Типы данных",
                Description = "Практика C#. Введение, Типы данных",
                CodeLink = "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson7_ASCII_Art",
                PresentationLink = "https://docs.google.com/document/d/1Oo-xFjrBTRgZJy3Dhi53NJN2wqg061vW/",
                HomeworkLink = "https://docs.google.com/document/d/1BKNGM6YlzMnnnm__1CDrxCJNBMaDFWC0dxXbSoEbAmc/",
                VideoLink = "https://www.youtube.com/embed/MalBSL6rPkg"
            });

            result.Add(new Lesson
            {
                Id = 8,
                Name = "Практика C#. Условные операторы, циклы",
                Description = "Практика C#. Условные операторы, циклы",
                CodeLink = "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson8_Shapes_Homework",
                VideoLink = "https://www.youtube.com/embed/qccCxSfjA1c",
                HomeworkLink = "https://docs.google.com/document/d/1MguH6immkhXPz3tOV1SxtzUTKAAUx7Hti44UnIMwkQA/"
            });

            result.Add(new Lesson
            {
                Id = 9,
                Name = "Теория ООП. Матчасть",
                Description = "Теория ООП. Матчасть",
                CodeLink = "",
                VideoLink = "https://www.youtube.com/embed/-gmsUz1gBBU",
                HomeworkLink = ""
            });

            result.Add(new Lesson
            {
                Id = 10,
                Name = "ООП. Инкапсуляция",
                Description = "ООП. Инкапсуляция",
                CodeLink = "",
                VideoLink = "https://www.youtube.com/embed/8-vUcb0b7Hc",
                HomeworkLink = ""
            });

            result.Add(new Lesson
            {
                Id = 11,
                Name = "ООП. Наследование",
                Description = "ООП. Наследование",
                CodeLink = "",
                VideoLink = "https://www.youtube.com/embed/F6FI1ZeRv_s",
                HomeworkLink = ""
            });

            result.Add(new Lesson
            {
                Id = 12,
                Name = "ООП. Полиморфизм",
                Description = "ООП. Полиморфизм",
                CodeLink = "",
                VideoLink = "https://www.youtube.com/embed/cEPrxbyodA0",
                HomeworkLink = ""
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
