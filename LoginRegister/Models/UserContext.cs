using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LoginRegister.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get; set;}
    }
}