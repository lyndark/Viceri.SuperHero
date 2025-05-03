
using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Dto
{
    public class HeroRequestDto
    {
        public string? Name { get; set; }
        public string? HeroName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public HeroRequestDto()
        {

        }

        public void Map(Hero hero)
        {
            hero.Name = Name;
            hero.HeroName = HeroName;
            hero.DateOfBirth = DateOfBirth;
            hero.Height = Height;
            hero.Weight = Weight;
        }
    }
}
