using HomeWorkAspNetCoreMVC.Models.Entity;
using Microsoft.EntityFrameworkCore;


namespace HomeWorkAspNetCoreMVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } 
    }
}
