using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUDelicious.Models
{
    public class DishContext : DbContext
    {
        public DishContext(DbContextOptions options) : base(options) { }
        public DbSet<theDish> Dishes {get; set;}
    }
}