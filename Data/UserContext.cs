using Microsoft.EntityFrameworkCore;
using Sweady_training.Models;

namespace Sweady_training.Data
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> user { get; set; }

    }
}
