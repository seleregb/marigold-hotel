namespace HotelReservation.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("City")]
    public class City
    {
        public City() => Customers = new HashSet<Customer>();

        public string CityID { get; set; }

        [StringLength(250)]
        public string CityName { get; set; }

        public string ProvinceID { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

        public virtual Province Province { get; set; }
    }
}
