using Microsoft.EntityFrameworkCore;
using NepalTrek.API.Models.Domain;

namespace NepalTrek.API.Data
{
    public class NepalTrekDbContext:DbContext
    {
        public NepalTrekDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
