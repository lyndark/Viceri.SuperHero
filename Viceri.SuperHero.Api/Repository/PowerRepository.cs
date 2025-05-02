using Viceri.SuperHero.Api.Infrastructure;
using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Repository
{
    public class PowerRepository : BaseRepository<Power>
    {
        public PowerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
