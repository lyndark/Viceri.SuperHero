using System.ComponentModel.DataAnnotations;

namespace Viceri.SuperHero.Api.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
