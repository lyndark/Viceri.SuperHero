using Viceri.SuperHero.Api.Entity;
using Viceri.SuperHero.Api.Interface;
using Viceri.SuperHero.Api.Infrastructure;

namespace Viceri.SuperHero.Api.Repository
{
    public class HeroRepository(AppDbContext appDbContext) : BaseRepository<Hero>(appDbContext), IHeroRepository
    {
    }
}
