using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Zelda.Models.Attributes;

namespace Zelda.Models
{
    public class Costumer : IOrderData
    {
        [Key]
        [StringLength(9)]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter password between 6-12 charecters")]
        [MaxLength(12)]
        [MinLength(6)]
        [RegularExpression(".{6,12}$")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter between 3-25 charecters")]
        [MaxLength(25)]
        [MinLength(3)]
        [RegularExpression("[A-Za-z\\s]{3,25}$")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter between 3-25 charecters")]
        [MaxLength(25)]
        [MinLength(3)]
        [RegularExpression("[A-Za-z\\s]{3,25}$")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.DateTime)]
        [BirthDateValidation]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength (11)]
        [RegularExpression("[0-9]{3}-[0-9]{7}$")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        public virtual int CostumerAdrressID { get; set; }
        [Required]
        [ForeignKey("AdrressID")]
        public virtual Address? CostumerAdrress { get; set; }
    }
}
