using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;
using HotelReservation.Utilities.ValidationObjects;

namespace HotelReservation.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel() => Payments = new HashSet<Payment>();

        public string CustID { get; set; }
                
        public string UserID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+", ErrorMessage = "Should not contain numbers or special characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+", ErrorMessage = "Should not contain numbers or special characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Street number is required")]
        [Display(Name = "Street Number")]
        public int? StreetNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string CityID { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "Province is required")]
        [Display(Name = "Province")]
        public string ProvinceName { get; set; }

        [Required(ErrorMessage = "Postal Code is required 'A3B 0B1' ")]
        [Display(Name = "Postal Code")]
        [PostalValidate]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "City Name")]
        public string CityName { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public IEnumerable<CityViewModel> Cities { get; set; }

        public IEnumerable<ProvinceViewModel> Provinces { get; set; }

        public IEnumerable<CountryViewModel> Countries { get; set; }
        
        public string CustomerName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}

