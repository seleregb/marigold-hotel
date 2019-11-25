using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HotelReservation.Utilities.ValidationObjects
{
    public class PostalValidate: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
                            ValidationContext validationContext)
        {

            string str = value.ToString();

            if (!IsUSorCanadianZipCode(str))
            {
                return new ValidationResult("Invalid postal code. Format 'A3B 0B1' ");
            }

            return ValidationResult.Success;
        }

        private bool IsUSorCanadianZipCode(string zipCode)
        {
            string pattern = @"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(zipCode);
        }
    }
}
