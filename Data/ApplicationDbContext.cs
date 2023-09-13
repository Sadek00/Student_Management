using Microsoft.EntityFrameworkCore;
using Task_Quad_StudentManagement.Models;

namespace Task_Quad_StudentManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }
    }
}
