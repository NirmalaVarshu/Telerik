
using College.Models;
using Microsoft.EntityFrameworkCore;
namespace College.Data
{
    public class AppDb : DbContext

    {
        public AppDb(DbContextOptions<AppDb> options) : base(options) { }
        public DbSet<StudentModel> Student { get; set; }

        public DbSet<Administator> admin { get; set; }

        public DbSet<ProfessorModel> Professors { get; set; }
    }
}
