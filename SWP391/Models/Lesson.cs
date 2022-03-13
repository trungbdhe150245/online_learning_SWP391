using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        public string LessonId { get; set; }
        public string LessonName { get; set; }
        public int LessonOrder { get; set; }
        public string Script { get; set; }
        public string VideoURL { get; set; }
        public virtual Topic Topic { get; set; }
        public string TopicId { get; set; }
    }
}
