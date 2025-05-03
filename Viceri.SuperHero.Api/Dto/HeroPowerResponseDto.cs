using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Dto
{
    public class HeroPowerResponseDto : HeroResponseDto
    {
        public List<PowerResponseDto> Powers { get; set; } = new List<PowerResponseDto>();
        
        public HeroPowerResponseDto()
        {
                
        }

        public HeroPowerResponseDto(Hero hero)
        {
            Id = hero.Id;
            Name = hero.Name;
            HeroName = hero.HeroName;
            DateOfBirth = hero.DateOfBirth;
            Height = hero.Height;
            Weight = hero.Weight;
            Powers = hero.Powers.ToResponseDto();
        }
    }
}
