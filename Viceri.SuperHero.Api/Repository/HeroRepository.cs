using Viceri.SuperHero.Api.Infrastructure;
using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Repository
{
    public class HeroRepository : BaseRepository<Hero>
    {
        public HeroRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
