using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using Learn.Models.Domain;


namespace Learn.Data
{
    public class LearnDbContext : DbContext
    {
        public LearnDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Walk> Walking { get; set; }

    }
}