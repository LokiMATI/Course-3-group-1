using Microsoft.EntityFrameworkCore;
using Core = MyWebSolution.Models.Core;

namespace MyWebSolution.Models.DB
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Core.Task> Tasks { get; set; } = null!;
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}
