using Microsoft.EntityFrameworkCore;
using TaskManager.Entities;

namespace TaskManager.Data
{
    public class TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options):DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TaskTable> Tasks { get; set; }
    }
}