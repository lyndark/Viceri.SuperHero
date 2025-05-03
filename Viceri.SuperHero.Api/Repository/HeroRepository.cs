using Viceri.SuperHero.Api.Entity;
using Viceri.SuperHero.Api.Interface;
using Viceri.SuperHero.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Viceri.SuperHero.Api.Exception;

namespace Viceri.SuperHero.Api.Repository
{
    public class HeroRepository(AppDbContext appDbContext) : BaseRepository<Hero>(appDbContext), IHeroRepository
    {
        public async Task<Hero?> GetHeroPowerById(int id)
        {
            var hero = await DbSet
                .Where(x => x.Id == id)
                .Include(x => x.Powers)
                .FirstOrDefaultAsync();

            return hero;
        }
    }
}
