
namespace MvcIntro.Models
{
    public class Slider : BaseEntity
    {
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Descreption { get; set; }
        public string ImageURL { get; set; }
        public int Order { get; set; }
     
    }
}
