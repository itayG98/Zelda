using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class IceCream : ICloneable, IMenuItem
    {
        [Key]
        public int IceCreamID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? ImgSrc { get; set; }

        public object Clone() => MemberwiseClone();

        public override string ToString()
        {
            return $"{Name} Ice-Cream costs {Price:c}"; 
        }

    }
}
