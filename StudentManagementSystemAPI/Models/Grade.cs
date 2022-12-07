namespace StudentManagementSystemAPI.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int LessonId { get; set; }
        public int LecturerId { get; set; }
        public int StudentId { get; set; }
        public List<int> Score { get; set; }
        public List<int> ScoreWeight { get; set; }
    }
}
