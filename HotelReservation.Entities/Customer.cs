namespace HotelReservation.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Customer")]
    public class Customer
    {
        public Customer() => Payments = new HashSet<Payment>();

        [Key]
        public string CustID { get; set; }

        [StringLength(450)]
        public string UserID { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        public int? StreetNumber { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public string CityID { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(250)]
        public string EmailAddress { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
