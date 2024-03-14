using Microsoft.EntityFrameworkCore;
using NepalTrek.API.Data;
using NepalTrek.API.Models.Domain;

namespace NepalTrek.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly NepalTrekDbContext dbContext;

        public SQLWalkRepository(NepalTrekDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await dbContext.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }
    }
}
