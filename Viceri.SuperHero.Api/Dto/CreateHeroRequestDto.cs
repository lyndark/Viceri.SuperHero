
namespace Viceri.SuperHero.Api.Dto
{
    public class CreateHeroRequestDto
    {
        public string? Name { get; set; }
        public string? HeroName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
