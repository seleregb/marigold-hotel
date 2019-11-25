namespace HotelReservation.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Country")]
    public class Country
    {
        public Country() => Provinces = new HashSet<Province>();

        public string CountryID { get; set; }

        [StringLength(250)]
        public string CountryName { get; set; }

        public virtual ICollection<Province> Provinces { get; set; }
    }
}
