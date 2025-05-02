using System.ComponentModel.DataAnnotations;

namespace Viceri.SuperHero.Api.Entity
{
    public class Hero : BaseEntity
    {
        [Required]
        [MaxLength(120)] 
        public string? Name { get; set; }

        [Required]
        [MaxLength(120)]
        public string? HeroName { get; set; }

        [MaxLength(7)]
        public DateTime DateOfBirth { get; set; }

        [Required] 
        public double Height { get; set; }

        [Required] 
        public double Weight { get; set; } 

        public ICollection<Power> Powers { get; set; } = new List<Power>();
    }
}