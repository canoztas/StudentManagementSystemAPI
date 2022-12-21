using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Repository.IRepository
{
    public interface IGradeRepository
    {
        Task<Grade> GetAsync(int id);
        Task CreateAsync(Grade grade);
        Task UpdateAsync(Grade grade);
        Task RemoveAsync(Grade grade);
        List<Grade> GetByStudentId(int id);
        List<Grade> GetByLecturerId(int id);
        Task SaveAsync();
    }
}
