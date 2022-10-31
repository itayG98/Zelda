using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zelda.Models
{
    public class Costumer : IOrdersData
    {
        [Key]
        [StringLength(9)]
        public string CustomerID { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public int AdrressID { get; set; }
        [ForeignKey("AdrressID")]
        [Required]
        public Address? Adrress { get; set; }
    }
}
