using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Repository.IRepository
{
    public interface ILessonRepository
    {
        Task<User> GetAsync(int id);
        Task CreateAsync(Lesson lesson); 
        Task UpdateAsync(Lesson lesson);
        Task RemoveAsync(Lesson lesson);
        Task SaveAsync();
    }
}
