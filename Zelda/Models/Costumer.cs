﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zelda.Models
{
    public class Costumer : IOrderData
    {
        [Key]
        [StringLength(9)]
        public string CustomerID { get; set; }

        [Required(ErrorMessage ="Please enter password between 6-12 charecters")]
        [RegularExpression(".+")]
        [MinLength(6)][MaxLength(12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter between 3-25 charecters")]
        [MaxLength(25)]
        [MinLength(3)]
        [RegularExpression("[A-Za-z\\s]*$")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter between 3-25 charecters")]
        [MaxLength(25)]
        [MinLength(3)]
        [RegularExpression("[A-Za-z\\s]*$")]
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
        public virtual int CostumerAdrressID { get; set; }
        [Required]
        [ForeignKey("AdrressID")]
        public virtual Address? CostumerAdrress { get; set; }
    }
}
