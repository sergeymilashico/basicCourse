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
                Name = "Введение в специальность. Архитектура PC",
                Description = "Введение в специальность. Архитектура PC",
                CodeLinks = null,
                VideoLinks = new List<string> { 
                    "https://www.youtube.com/embed/1dFm8aRkyVw",
                    "https://www.youtube.com/embed/Ls4tPJ9TERk"
                }
            });

            result.Add(new Lesson
            {
                Id = 2,
                Name = "Создание сайтов",
                Description = "Создание сайтов с помощью Balsamiq и Bootstrap",
                CodeLinks = new List<string> { "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson3_WebSite" },
                VideoLinks = new List<string> { "https://www.youtube.com/embed/gAYBYPjuYeQ" },
                PresentationLink = "https://docs.google.com/document/d/1tFqw-qKREnsh9vw04aSqRGHiy2zHok-4/",
            }) ;

            result.Add(new Lesson
            {
                Id = 3,
                Name = "Языки программирования",
                Description = "Языки программирования, история C#, Типы",
                CodeLinks = null,
                PresentationLink= "https://docs.google.com/document/d/1Oo-xFjrBTRgZJy3Dhi53NJN2wqg061vW/",

                VideoLinks = new List<string> { "https://www.youtube.com/embed/IWPIr9GRiFo" }
            });

            result.Add(new Lesson
            {
                Id = 4,
                Name = "GitHub, VS Code, Первая программа",
                Description = "GitHub, VS Code, Первая программа",
                CodeLinks = null,
                PresentationLink = "https://docs.google.com/document/d/1Oo-xFjrBTRgZJy3Dhi53NJN2wqg061vW/",
                VideoLinks = new List<string> { "https://www.youtube.com/embed/I47EwlCj3ZE" }
            });

            result.Add(new Lesson
            {
                Id = 5,
                Name = "Синтаксис языка C#",
                Description = "Синтаксис языка C#",
                CodeLinks = new List<string> {
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson5_Basics",
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson6_Loops"
                },
                VideoLinks = new List<string> {
                    "https://www.youtube.com/embed/jZCb1tYESD4",
                    "https://www.youtube.com/embed/P97QTKisSRg"
                }
            });

            result.Add(new Lesson
            {
                Id = 6,
                Name = "Практика C#",
                Description = "Практика C#",
                CodeLinks = new List<string> {
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson7_ASCII_Art",
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson8_Shapes_Homework" 
                },
                PresentationLink = "https://docs.google.com/document/d/1Oo-xFjrBTRgZJy3Dhi53NJN2wqg061vW/",
                VideoLinks = new List<string> {
                    "https://www.youtube.com/embed/MalBSL6rPkg",
                    "https://www.youtube.com/embed/qccCxSfjA1c",
                    "https://www.youtube.com/embed/zZFdpOGYIpI",
                    "https://www.youtube.com/embed/4XB3DnGWU1I"
                }
            });

            result.Add(new Lesson
            {
                Id = 7,
                Name = "Теория ООП",
                Description = "Теория ООП",
                CodeLinks = null,
                VideoLinks = new List<string> { "https://www.youtube.com/embed/-gmsUz1gBBU" },
            });

            result.Add(new Lesson
            {
                Id = 8,
                Name = "Практика ООП",
                Description = "Практика ООП",
                CodeLinks = new List<string> {
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson9_Encapsulation",
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson10_OOP_Inheritance",
                    "https://github.com/sergeymilashico/basicCourse/tree/main/Lesson11_OOP_Polymorphysm"
                },
                VideoLinks = new List<string> {
                    "https://www.youtube.com/embed/8-vUcb0b7Hc",
                    "https://www.youtube.com/embed/F6FI1ZeRv_s",
                    "https://www.youtube.com/embed/cEPrxbyodA0"
                }
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
