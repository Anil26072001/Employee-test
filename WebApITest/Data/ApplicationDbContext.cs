using Microsoft.EntityFrameworkCore;
using WebApITest.Models;

namespace WebApITest.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
                
        }
        public DbSet<Employee> Employee { get; set; }

    }
}
