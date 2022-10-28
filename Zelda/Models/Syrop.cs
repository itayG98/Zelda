using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Syrop : ICloneable, IItem
    {
        [Key]
        public int SyropID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? ImgSrc { get; set; }

        public object Clone() => MemberwiseClone();

        public override string ToString()
        {
            return $"{Name} Syrop costs {Price:c}";
        }

    }
}