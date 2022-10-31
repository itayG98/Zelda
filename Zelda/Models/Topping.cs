using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Topping : ICloneable , IMenuItem
    {
        [Key]
        public int ToppingID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? ImgSrc { get; set; }

        public object Clone() => MemberwiseClone();

        public override string ToString()
        {
            return $"{Name} Topping costs {Price:c}";
        }

    }
}
