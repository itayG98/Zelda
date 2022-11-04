using System.ComponentModel.DataAnnotations;

namespace Zelda.Models.Attributes
{
    /// <summary>
    /// Validate the Birthdate of person betwwen 12 to 135 years old
    /// </summary>
    public class BirthDateValidationAttribute :  ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateTime != default)
            {
                int Years = (int)DateTime.Now.Subtract(dateTime).TotalDays / 365;
                if (Years > 135)
                {
                    return new ValidationResult("This birthDate is unvalid .Please specify earlier date");
                }
                else if (Years > 12)
                {
                    return new ValidationResult("This birthDate is unvalid .Please specify a date afterwards");
                }
                else
                    return ValidationResult.Success;
            }
            return new ValidationResult("This is now a valid date ");
        }
    }
}
