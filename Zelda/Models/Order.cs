using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Zelda.Models
{
    public class Order : ICloneable, IOrderData
    {
        [Key]
        public Guid OrderID { get; set; }

        [Required]
        [MaxLength(9)]
        public virtual string CostumerID { get; set; }
        [Required]
        [ForeignKey("CostumerID")]
        public virtual Costumer Costumer { get; set; }

        [Required]
        public virtual int? OrderedIceCreamID { get; set; }
        [Required]
        [ForeignKey("OrderedIceCreamID")]
        public virtual IceCream? OrderedIceCream { get; set; }

        [Required]
        public virtual int? ToopingSyropID { get; set; }
        [Required]
        [ForeignKey("ToopingSyropID")]
        public virtual Syrop? ToopingSyrop { get; set; }
        [Required]
        public virtual int? ToppingID { get; set; }
        [Required]
        [ForeignKey("ToppingID")]
        public virtual Topping? Top { get; set; }

        public virtual int? AlternativeAdrressID { get; set; }

        [ForeignKey("AlternativeAdrressID")]
        public virtual Address? AlternativeAdrress { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{7}$")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string? AdditionalPhoneNumber { get; set; }



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
