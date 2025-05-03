using System.ComponentModel.DataAnnotations;
using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Dto
{
    public class PowerResponseDto
    {
        public int Id { get; set; }
        public string? Superpower { get; set; }

        public string? Description { get; set; }
    }

    public static class PowerResponseDtoExtensions
    {
        public static List<PowerResponseDto> ToResponseDto(this IEnumerable<Power> powers)
        {
            return [.. powers.Select(power => new PowerResponseDto
            {
                Id = power.Id,
                Superpower = power.Superpower,
                Description = power.Description
            })];
        }
    }
}
