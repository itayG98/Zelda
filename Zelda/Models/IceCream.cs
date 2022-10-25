using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class IceCream : ICloneable
    {
        [Key]
        [MinLength(7)]
        public string IceCreamID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? imgSrc { get; set; }

        public object Clone() => MemberwiseClone();
        
    }
}
