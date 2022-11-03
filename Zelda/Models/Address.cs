using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Address : ICloneable , IOrderData
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required]
        [StringLength(7)]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        public object Clone() => MemberwiseClone();

    }
}
