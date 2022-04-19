namespace Trainings.Web.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public List<string> VideoLinks {get;set;}

        public List<string> CodeLinks {get;set;}

        public string PresentationLink { get; set; }

        public string ReadingsLink { get; set; }

    }
}
