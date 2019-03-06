using Microsoft.EntityFrameworkCore;

namespace boakyepieshop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Category{ get; set;}
        public DbSet<Pie> Pies {get; set;}
    }
}