using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;

namespace HotelReservation.ViewModels
{
    public class CountryViewModel
    {
        public CountryViewModel() => Provinces = new HashSet<Province>();

        public string CountryID { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Display(Name = "Country")]
        public string CountryName { get; set; }

        public virtual ICollection<Province> Provinces { get; set; }
    }
}
