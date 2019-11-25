using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;

namespace HotelReservation.ViewModels
{
    public class CityViewModel
    {
        public CityViewModel() => Customers = new HashSet<Customer>();

        public string CityID { get; set; }

        [Required(ErrorMessage = "The City Name is required")]
        [Display(Name = "City Name")]
        [StringLength(250)]
        public string CityName { get; set; }

        [Required(ErrorMessage = "Province Is Required")]
        public string ProvinceID { get; set; }

        [Required(ErrorMessage = "Province is Required")]
        [Display(Name = "Province")]
        public string ProvinceName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

        public virtual Province Province { get; set; }
    }
}
