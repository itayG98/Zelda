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
        [MinLength(6)][MaxLength(12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        public int AdrressID { get; set; }
        [ForeignKey("AdrressID")]
        [Required]
        public Address? Adrress { get; set; }
    }
}
