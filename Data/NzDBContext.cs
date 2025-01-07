using Microsoft.EntityFrameworkCore;
using Learn.Models.Domain.Walks;
using Learn.Models.Domain.Region;
using Learn.Models.Domain.Difficulty;

namespace Learn.Data
{
    public class LearnDbContext : DbContext
    {
        public LearnDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Walks> Walking { get; set; }

    }
}