namespace HotelReservation.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Province")]
    public class Province
    {
        public Province() => Cities = new HashSet<City>();

        public string ProvinceID { get; set; }

        [StringLength(250)]
        public string ProvinceName { get; set; }

        public string CountryID { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual Country Country { get; set; }
    }
}
