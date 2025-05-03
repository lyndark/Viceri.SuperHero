using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Interface
{
    public interface IHeroRepository : IBaseRepository<Hero>
    {
        public Task<Hero?> GetHeroPowerById(int id);
    }
}
