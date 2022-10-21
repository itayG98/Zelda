using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class IceCream : ICloneable
    {
        [Key]
        public int IceCreamID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? imgSrc { get; set; }
        public Syrop ToppingSyrop { get; set; }



        public object Clone()
        {
            IceCream iceCream = new()
            {
                IceCreamID = IceCreamID,
                Name = Name,
                Price = Price,
                imgSrc = imgSrc.ToString(),
                ToppingSyrop = ToppingSyrop
            };
            return iceCream;
        }

        public double CalculatePrice() => ToppingSyrop.Price + Price;
    }
}
