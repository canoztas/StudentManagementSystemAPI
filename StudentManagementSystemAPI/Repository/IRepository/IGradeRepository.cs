using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Repository.IRepository
{
    public interface IGradeRepository
    {
        Task<Grade> GetAsync(int id);
        Task CreateAsync(Grade grade); 
        Task UpdateAsync(Grade grade);
        Task RemoveAsync(Grade grade);
        Task SaveAsync();
    }
}
