using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;

namespace StudentManagementSystemAPI.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private readonly DbContext _context;

        public GradeRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Grade> GetAsync(int id)
        {
            return await _context.Grades.FindAsync(id);
        }

        public async Task CreateAsync(Grade grade)
        {
            await _context.Grades.AddAsync(grade);
        }

        public async Task UpdateAsync(Grade grade)
        {
            await _context.Grades.UpdateAsync(grade);
        }

        public async Task RemoveAsync(Grade grade)
        {
            await _context.Grades.Remove(grade);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}
