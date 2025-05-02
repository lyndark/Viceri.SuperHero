using Viceri.SuperHero.Api.Dto;

namespace Viceri.SuperHero.Api.Service
{
    public interface IHeroService
    {
        public Task CreateHero(CreateHeroRequestDto request);
    }
}
