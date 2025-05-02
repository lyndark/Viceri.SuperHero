using Viceri.SuperHero.Api.Entity;
using Viceri.SuperHero.Api.Interface;
using Viceri.SuperHero.Api.Infrastructure;

namespace Viceri.SuperHero.Api.Repository
{
    public class PowerRepository(AppDbContext appDbContext) : BaseRepository<Power>(appDbContext), IPowerRepository
    {
    }
}
