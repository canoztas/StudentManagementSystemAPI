
namespace StudentManagementSystemAPI.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public int LecturerId { get; set; }
        public List<DateTime> LessonDate { get; set; }
    }
}
