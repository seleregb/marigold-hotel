using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;

namespace HotelReservation.ViewModels
{
    public class ProvinceViewModel
    {
        public ProvinceViewModel() => Cities = new HashSet<City>();

        public string ProvinceID { get; set; }

        [Required(ErrorMessage = "Province is required")]
        [Display(Name = "Province")]
        public string ProvinceName { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string CountryID { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Display(Name = "Country")]
        public string CountryName { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual Country Country { get; set; }
    }
}
