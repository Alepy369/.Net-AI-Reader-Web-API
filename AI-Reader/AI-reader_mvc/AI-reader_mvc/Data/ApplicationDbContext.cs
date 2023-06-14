using AI_reader_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace AI_reader_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
