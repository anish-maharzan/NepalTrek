using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NepalTrek.API.Data
{
    public class NepalTrekAuthDbContext : IdentityDbContext
    {
        public NepalTrekAuthDbContext(DbContextOptions<NepalTrekAuthDbContext> options) : base(options)
        {
        }
    }
}
