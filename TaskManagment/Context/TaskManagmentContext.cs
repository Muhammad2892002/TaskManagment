using Microsoft.EntityFrameworkCore;
using TaskManagment.Models;

namespace TaskManagment.Context
{
    public class TaskManagmentContext : DbContext
    {
        public TaskManagmentContext(DbContextOptions<TaskManagmentContext> options) : base(options)
        {
           

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(u=>u.Username).IsUnique();
            modelBuilder.Entity<Lookup>().HasData(
                
                new Lookup { Id=1,MajorCode=1,MinorCode=0,Name="Task Status" },
                new Lookup { Id=2,MajorCode=1,MinorCode=1,Name="Initiated" },
                new Lookup { Id=3,MajorCode=1,MinorCode=2,Name="In Progress" },
                new Lookup { Id=4,MajorCode=1,MinorCode=3,Name="Completed" },
                new Lookup { Id=5,MajorCode=1,MinorCode=4,Name="Cancelled" }
                
                
            
              
                

                );
            
            
            

        }

        public DbSet<Lookup>Lookups { get; set; }
        public DbSet<User>User { get; set; }

        public DbSet<Models.Task>Tasks { get; set; }

    }
}
