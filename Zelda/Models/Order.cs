using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }

        [Required]
        [MaxLength(25)]
        public string CostumerID { get; set; }

        [StringLength(10)]
        public string AdditionalPhoneNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }
        [Required]
        [MaxLength(20)]
        public string Adrress { get; set; }

        [Required]
        public IceCream? OrderedIceCream { get; set; }
        public bool IsValid() => OrderedIceCream != default && CostumerID != default;

        public double Price() => OrderedIceCream != default ? OrderedIceCream.CalculatePrice() : default;
    }
}
