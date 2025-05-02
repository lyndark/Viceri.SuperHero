using Viceri.SuperHero.Api.Dto;
using Viceri.SuperHero.Api.Entity;
using Viceri.SuperHero.Api.Interface;

namespace Viceri.SuperHero.Api.Service
{
    public class HeroService : IHeroService
    {
        public IHeroRepository HeroRepository { get; set; }
        public HeroService(IHeroRepository heroRepository)
        {
            HeroRepository = heroRepository;

        }

        public async Task CreateHero(CreateHeroRequestDto request)
        {
            var hero = new Hero
            {
                Name = request.Name,
                HeroName = request.HeroName,
                DateOfBirth = request.DateOfBirth,
                Height = request.Height,
                Weight = request.Weight
            };

            if( await HeroRepository.Exist(x => x.Name == request.Name))
            {
                throw new Exception("Herói já cadastrado!");
            }

            await HeroRepository.Insert(hero);
            await HeroRepository.SaveChanges();
        }
    }
}
