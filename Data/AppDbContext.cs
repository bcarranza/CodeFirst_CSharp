using Microsoft.EntityFrameworkCore;
using CodeFirstAPI.Models;

namespace CodeFirstAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Post> Posts { get; set; }
    }
}
