using System.ComponentModel.DataAnnotations;

namespace Zelda.Models
{
    public class Syrop
    {
        [Key]
        public int SyropID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; } = 3;
        [Required]
        public string? imgSrc { get; set; }

        public object Clone()
        {
            Syrop syrop = new()
            {
                SyropID = SyropID,
                Name = Name,
                Price = Price,
                imgSrc = imgSrc.ToString(),
            };
            return syrop;
        }
    }
}