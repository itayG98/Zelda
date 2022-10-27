using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Topping : ICloneable
    {
        [Key]
        public int ToppingID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? imgSrc { get; set; }

        public object Clone() => MemberwiseClone();

    }
}
