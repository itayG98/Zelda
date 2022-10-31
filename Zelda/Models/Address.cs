using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zelda.Models
{
    public class Address : ICloneable , IOrdersData
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Country { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Street { get; set; }

        [Required]
        [StringLength(7)]
        public string ZipCode { get; set; }

        public object Clone() => MemberwiseClone();

    }
}
