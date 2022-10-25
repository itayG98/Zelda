using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Syrop : ICloneable
    {
        [Key]
        [MinLength(7)]
        public string SyropID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? imgSrc { get; set; }

        public object Clone() => MemberwiseClone();

    }
}