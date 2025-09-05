using githubcicd.Models;
using Microsoft.EntityFrameworkCore;

namespace githubcicd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        
        public DbSet<Employee> Employees { get; set; }

    }
}