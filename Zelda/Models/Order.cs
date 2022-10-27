using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Zelda.Models
{
    public class Order : ICloneable
    {
        [Key]
        public Guid OrderID { get; set; }

        [Required]
        [MaxLength(9)]
        public string CostumerID { get; set; }
        [Required]
        [ForeignKey("CostumerID")]
        public Costumer Costumer { get; set; }

        [Required]
        public int? OrderedIceCreamID { get; set; }
        [Required]
        [ForeignKey("OrderedIceCreamID")]
        public IceCream? OrderedIceCream { get; set; }

        [Required]
        public int? ToopingSyropID { get; set; }
        [Required]
        [ForeignKey("ToopingSyropID")]
        public Syrop? ToopingSyrop { get; set; } 
        [Required]
        public int? ToppingID { get; set; }
        [Required]
        [ForeignKey("ToppingID")]
        public Topping? Top { get; set; }

        [StringLength(10)]
        public string? AdditionalPhoneNumber { get; set; }

        public int? AlternativeAddrresID { get; set; }

        public object Clone() => MemberwiseClone();


        public bool IsValid() => OrderedIceCream != default && CostumerID != default;

        public double Price() 
        {
            if (OrderedIceCream != default)
            {
                if (ToopingSyrop != default)
                    return ToopingSyrop.Price + OrderedIceCream.Price;
                else
                    return OrderedIceCream.Price;
            }
            else
                return default;
        }
    }
}
