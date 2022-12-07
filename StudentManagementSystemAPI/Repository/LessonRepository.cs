using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;

namespace StudentManagementSystemAPI.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private readonly List<Grade> _grades;

        public GradeRepository()
        {
            _grades = new List<Grade>();
        }

        public Grade GetGradeById(int gradeId)
        {
            return _grades.FirstOrDefault(g => g.GradeId == gradeId);
        }

        public IEnumerable<Grade> GetAllGrades()
        {
            return _grades;
        }

        public IEnumerable<Grade> GetGradesByLessonId(int lessonId)
        {
            return _grades.Where(g => g.LessonId == lessonId);
        }

        public IEnumerable<Grade> GetGradesByLecturerId(int lecturerId)
        {
            return _grades.Where(g => g.LecturerId == lecturerId);
        }

        public IEnumerable<Grade> GetGradesByStudentId(int studentId)
        {
            return _grades.Where(g => g.StudentId == studentId);
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void UpdateGrade(Grade grade)
        {
            var existingGrade = _grades.FirstOrDefault(g => g.GradeId == grade.GradeId);
            if (existingGrade != null)
            {
                existingGrade.LessonId = grade.LessonId;
                existingGrade.LecturerId = grade.LecturerId;
                existingGrade.StudentId = grade.StudentId;
                existingGrade.Score = grade.Score;
                existingGrade.ScoreWeight = grade.ScoreWeight;
            }
        }

        public void DeleteGrade(int gradeId)
        {
            var existingGrade = _grades.FirstOrDefault(g => g.GradeId == gradeId);
            if (existingGrade != null)
            {
                _grades.Remove(existingGrade);
            }
        }
    }

}
