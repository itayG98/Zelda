using System.ComponentModel.DataAnnotations;
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
        public IceCream? OrderedIceCream { get; set; }    

        public Syrop? ToopingSyrop { get; set; }

        [StringLength(10)]
        public string AdditionalPhoneNumber { get; set; }

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
