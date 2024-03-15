using Microsoft.EntityFrameworkCore;
using NepalTrek.API.Models.Domain;

namespace NepalTrek.API.Data
{
    public class NepalTrekDbContext : DbContext
    {
        public NepalTrekDbContext(DbContextOptions<NepalTrekDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id=Guid.Parse("96458856-4c06-4885-8e74-858340ef700e"),
                    Name="Easy"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("20ce24f5-2c3b-4054-993d-5f50e4d842a3"),
                    Name="Medium"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("9ecb8c2e-01e5-443c-aef3-46b00a4077c0"),
                    Name="Hard"
                }
            };

            // seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // seed data for regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id= Guid.Parse("ffc0b296-6648-4aab-9dc3-4af94ef23dd0"),
                    Name="Annapurna Base Camp",
                    Code="ABC",
                    RegionImageUrl="https://www.marveladventure.com/uploads/editors/Annapurna-Base-Camp-Trek-in-January-and-February-1.jpg",
                },
                  new Region
                {
                    Id= Guid.Parse("eaf3f13e-a9ba-4b61-abf5-12e1bddc7e7c"),
                    Name="Everest Base Camp",
                    Code="EBC",
                    RegionImageUrl="https://worldalpinetreks.com/uploads/2022/11/everest-base-camp-short-trek-scaled-e1641875466943.jpg",
                },
                   new Region
                {
                    Id= Guid.Parse("9cc9aabe-887d-42dc-abc5-d01051ef1be9"),
                    Name="Langtang Valley Trek",
                    Code="LVT",
                    RegionImageUrl="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.magicalsummits.com%2Flangtang-valley-trek%2F&psig=AOvVaw0b8m52a_8I4LgEhEw2Hvyg&ust=1710485873372000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMDy8cqW84QDFQAAAAAdAAAAABAE",
                },
                   new Region
                {
                    Id= Guid.Parse("1c9aa80b-846c-42cd-a86b-af91cb3d22a0"),
                    Name="Manaslu Circuit Trek",
                    Code="MCT",
                    RegionImageUrl="https://www.nepalfootprintholiday.com/wp-content/uploads/2022/06/manaslu-trek-photo.webp",
                },
                    new Region
                {
                    Id= Guid.Parse("4a44a12c-4ecc-44ad-9576-5b87d4c88776"),
                    Name="Machhapuchhare Base Camp",
                    Code="MBC",
                    RegionImageUrl="https://www.environmentaltrekking.com/public/uploads/machhapuchhre-base-camp-trek1.jpg",
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
