using Microsoft.EntityFrameworkCore;

namespace Fii.DataLayer
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().Property(t => t.IsCompleted).IsRequired();
            modelBuilder.Entity<Todo>().Property(t => t.Description).IsRequired().HasMaxLength(50);
        }
    }
}
