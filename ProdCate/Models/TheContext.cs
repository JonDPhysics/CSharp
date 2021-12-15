using Microsoft.EntityFrameworkCore;

namespace ProdCate.Models
{
    public class TheContext : DbContext
    {
        public TheContext(DbContextOptions options) : base(options) { }
        public DbSet<Prod> Prods {get; set;}
        public DbSet<Cate> Cates {get; set;}
        public DbSet<Asso> Assos {get; set;}
    }
}