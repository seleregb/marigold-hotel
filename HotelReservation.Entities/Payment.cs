namespace HotelReservation.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Payment")]
    public class Payment
    {
        public string PaymentID { get; set; }

        public string ResID { get; set; }

        public string CustID { get; set; }

        public string PaymentMethodID { get; set; }

        public double? PaymentAmount { get; set; }

        [StringLength(500)]
        public string PaymentDetails { get; set; }

        public DateTime? PaymentDate { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

    }
}
