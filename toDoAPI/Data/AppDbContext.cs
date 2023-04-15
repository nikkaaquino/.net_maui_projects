using Microsoft.EntityFrameworkCore;
using toDoAPI.Models;

namespace toDoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}
