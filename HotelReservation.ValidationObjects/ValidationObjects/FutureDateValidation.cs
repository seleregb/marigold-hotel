using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Utilities.ValidationObjects
{
    public class FutureDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParse(Convert.ToString(value), out DateTime dateTime);

            return (isValid && DateTime.Compare(dateTime.Date,DateTime.Now.Date) >= 0);
        }
    }
}
