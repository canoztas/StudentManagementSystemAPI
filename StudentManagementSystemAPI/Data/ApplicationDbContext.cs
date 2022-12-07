using Microsoft.EntityFrameworkCore;
using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        { 
        
        }



    }
}
