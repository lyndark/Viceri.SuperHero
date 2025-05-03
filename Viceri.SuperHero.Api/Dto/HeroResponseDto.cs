using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Dto
{
    public class HeroResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? HeroName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public HeroResponseDto()
        {
                
        }

        public HeroResponseDto(Hero hero)
        {
            Id = hero.Id;
            Name = hero.Name;
            HeroName = hero.HeroName;
            DateOfBirth = hero.DateOfBirth;
            Height = hero.Height;
            Weight = hero.Weight;
        }
    }

    public static class HeroResponseDtoExtensions
    {
        public static List<HeroResponseDto> ToResponseDto(this IEnumerable<Hero> heroes)
        {
            return [.. heroes.Select(hero => new HeroResponseDto
            {
                Id = hero.Id,
                Name = hero.Name,
                HeroName = hero.HeroName,
                DateOfBirth = hero.DateOfBirth,
                Height = hero.Height,
                Weight = hero.Weight
            })];
        }
    }
}
