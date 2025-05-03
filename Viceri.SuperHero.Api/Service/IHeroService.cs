using Viceri.SuperHero.Api.Dto;

namespace Viceri.SuperHero.Api.Service
{
    public interface IHeroService
    {
        public Task CreateHero(HeroRequestDto request);
        public Task UpdateHero(int id, HeroRequestDto request);
        public Task DeleteHero(int id);
        public Task<HeroPowerResponseDto> GetHeroById(int id);
        public Task<IList<HeroResponseDto>> ListHero();
        public Task<IList<PowerResponseDto>> ListPower();
    }
}
