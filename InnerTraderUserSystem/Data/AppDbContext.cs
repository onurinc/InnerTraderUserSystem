using Microsoft.EntityFrameworkCore;
using InnerTraderUserSystem.Models;

namespace InnerTraderUserSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        

        
        }



    }
}
