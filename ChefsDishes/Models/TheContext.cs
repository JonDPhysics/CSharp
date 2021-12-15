using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Models
{
    public class TheContext : DbContext
    {
        public TheContext(DbContextOptions options) : base(options) { }
        public DbSet<Chef> Chefs {get; set;}
        public DbSet<Dish> Dishes {get; set;}
    }
}