﻿using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Costumer
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
    }
}