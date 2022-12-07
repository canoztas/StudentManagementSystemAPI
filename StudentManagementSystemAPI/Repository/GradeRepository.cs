using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;

namespace StudentManagementSystemAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
        }

        public User GetUserById(int userId)
        {
            return _users.FirstOrDefault(u => u.UserId == userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.UserId == user.UserId);
            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.PasswordHash = user.PasswordHash;
                existingUser.DepartmentId = user.DepartmentId;
                existingUser.PhotoPath = user.PhotoPath;
                existingUser.UserType = user.UserType;
                existingUser.LessonId = user.LessonId;
            }
        }

        public void DeleteUser(int userId)
        {
            var existingUser = _users.FirstOrDefault(u => u.UserId == userId);
            if (existingUser != null)
            {
                _users.Remove(existingUser);
            }
        }
    }
