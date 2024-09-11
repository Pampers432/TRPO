using Microsoft.EntityFrameworkCore;
using TestShop.Data.Models;

namespace TestShop.Data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            
        }

        public DbSet<Door> Door { get; set; }

        public DbSet<Category> Category { get; set; }

    }   
}
