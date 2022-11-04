using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Address : ICloneable , IOrderData
    {
        [Key]
        public int AddressID { get; set; }

        [Required(ErrorMessage = "Please enter your Country between 3-20 charecters")]
        [RegularExpression("[A-Za-z\\s]{3,20}$")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your City between 3-20 charecters")]
        [RegularExpression("[A-Za-z\\s]{3,20}$")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your Street between 3-20 charecters")]
        [RegularExpression("[A-Za-z\\s]{3,20}$")]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required]
        [RegularExpression("[0-9]{7}$")]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        public object Clone() => MemberwiseClone();

    }
}
