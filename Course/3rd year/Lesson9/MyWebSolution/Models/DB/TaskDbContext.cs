using Microsoft.EntityFrameworkCore;
using Core = MyWebSolution.Models.Core;

namespace MyWebSolution.Models.DB
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options){
            //Database.EnsureCreated();
        }

        public DbSet<Core.Task> Tasks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Server=(localdb)\\mssqllocaldb;Database=task;Trusted_Connection=True;");
        //}


    }
}
