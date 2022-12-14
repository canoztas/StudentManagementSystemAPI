using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;

namespace StudentManagementSystemAPI.Repository
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DbContext _context;

        public LessonRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Lesson> GetAsync(int id)
        {
            return await _context.Lessons.FindAsync(id);
        }

        public async Task CreateAsync(Lesson lesson)
        {
            await _context.Lessons.AddAsync(lesson);
        }

        public async Task UpdateAsync(Lesson lesson)
        {
            await _context.Lessons.Update(lesson);
        }

        public async Task RemoveAsync(Lesson lesson)
        {
            await _context.Lessons.Remove(lesson);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }


}
