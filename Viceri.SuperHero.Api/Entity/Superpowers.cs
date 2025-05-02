using System.ComponentModel.DataAnnotations;

namespace Viceri.SuperHero.Api.Entity
{
    public class Superpowers : BaseEntity
    {
        [Required]
        [MaxLength(50)] 
        public string? Superpower { get; set; }

        [MaxLength(250)] 
        public string? Description { get; set; }

        public ICollection<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}