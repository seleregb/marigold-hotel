namespace HotelReservation.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PaymentMethod")]
    public class PaymentMethod
    {
        public PaymentMethod() => Payments = new HashSet<Payment>();

        public string PaymentMethodID { get; set; }

        [StringLength(500)]
        public string PaymentDescription { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
