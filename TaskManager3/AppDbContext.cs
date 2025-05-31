using Microsoft.EntityFrameworkCore;

namespace TaskManager
{
    public class AppDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tasks2.db");
        }
    }
}
