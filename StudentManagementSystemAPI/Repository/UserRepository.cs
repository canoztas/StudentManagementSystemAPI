using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;

namespace StudentManagementSystemAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<User> GetAsync(int id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task CreateAsync(User user)
        {
            await _context.User.AddAsync(user);
        }

        public async Task UpdateAsync(User user)
        {
            await _context.User.Update(user);
        }

        public async Task RemoveAsync(User user)
        {
            await _context.User.Remove(user);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }


}
