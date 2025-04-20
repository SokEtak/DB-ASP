using DatabaseASP.NETWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseASP.NETWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
    }
}
