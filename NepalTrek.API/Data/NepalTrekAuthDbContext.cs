using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NepalTrek.API.Data
{
    public class NepalTrekAuthDbContext : IdentityDbContext
    {
        public NepalTrekAuthDbContext(DbContextOptions<NepalTrekAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "119bf1d5-5a2d-41cd-a78e-82d27c447dca";
            var writeRoleId = "b7bfeca4-0247-47eb-bd32-cb37e4f07a07";
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id=readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name="Reader",
                    NormalizedName="Reader".ToUpper()
                },
                new IdentityRole()
                {
                    Id = writeRoleId,
                    ConcurrencyStamp=writeRoleId,
                    Name="Writer",
                    NormalizedName="Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
