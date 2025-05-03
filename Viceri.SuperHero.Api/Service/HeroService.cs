using Viceri.SuperHero.Api.Dto;
using Viceri.SuperHero.Api.Entity;
using Viceri.SuperHero.Api.Exception;
using Viceri.SuperHero.Api.Interface;

namespace Viceri.SuperHero.Api.Service
{
    public class HeroService(IHeroRepository heroRepository, IPowerRepository powerRepository) : IHeroService
    {
        public IHeroRepository HeroRepository { get; set; } = heroRepository;
        public IPowerRepository PowerRepository { get; set; } = powerRepository;

        public async Task CreateHero(HeroRequestDto request)
        {
            var hero = new Hero
            {
                Name = request.Name,
                HeroName = request.HeroName,
                DateOfBirth = request.DateOfBirth,
                Height = request.Height,
                Weight = request.Weight
            };

            if(await HeroRepository.Exist(x => x.Name == request.Name))
                throw new ApiException("Herói já cadastrado!", false, null, 400);

            await HeroRepository.Insert(hero);
            await HeroRepository.SaveChanges();
        }

        public async Task DeleteHero(int id)
        {
            var entity = await HeroRepository.GetById(id, true);

            if (entity is null)
                throw new ApiException("Herói não encontrado!", false, null, 404);

            await HeroRepository.Delete(entity);
            await HeroRepository.SaveChanges();
        }

        public async Task<HeroPowerResponseDto> GetHeroById(int id)
        {
            var entity = await HeroRepository.GetHeroPowerById(id);

            if (entity is null)
                throw new ApiException("Herói não encontrado!", false, null, 404);
            
            return new HeroPowerResponseDto(entity);
        }

        public async Task<IList<HeroResponseDto>> ListHero()
        {
            var entities = await HeroRepository.GetAll();

            return entities.ToResponseDto();
        }

        public async Task<IList<PowerResponseDto>> ListPower()
        {
            var entities = await PowerRepository.GetAll();

            return entities.ToResponseDto();
        }

        public async Task UpdateHero(int id, HeroRequestDto request)
        {
            if (! await HeroRepository.Exist(x => x.Id == id))
                throw new ApiException("Herói não encontrado!", false, null, 404);

            var entity = await HeroRepository.GetById(id, true);

            request.Map(entity);
            
            await HeroRepository.Update(entity);
            await HeroRepository.SaveChanges();
        }
    }
}
