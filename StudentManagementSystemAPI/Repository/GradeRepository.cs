using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Data;
using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;
using System;
using System.Linq;
using static Azure.Core.HttpHeader;

namespace StudentManagementSystemAPI.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private readonly ApplicationDbContext _context;

        public GradeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Grade> GetAsync(int id)
        {
            return await _context.Grades.FindAsync(id);
        }
        public List<Grade> GetByStudentId(int id)
        {
            List<Grade> query = _context.Grades.ToList();

            return query.Where(g => g.StudentId == id).ToList();
        }

        public List<Grade> GetByLecturerId(int id)
        {
            List<Grade> query = _context.Grades.ToList();

            return query.Where(g => g.LecturerId == id).ToList();
        }


        public async Task CreateAsync(Grade grade)
        {
            await _context.Grades.AddAsync(grade);
        }

        public async Task UpdateAsync(Grade grade)
        {
             _context.Grades.Update(grade);
        }

        public async Task RemoveAsync(Grade grade)
        {
             _context.Grades.Remove(grade);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}
