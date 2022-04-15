namespace Trainings.Web.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        
        public string VideoLink {get;set;}

        public string CodeLink {get;set;}

        public string PresentationLink { get; set; }

        public string HomeworkLink { get; set; }

        public string ReadingsLink { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}
