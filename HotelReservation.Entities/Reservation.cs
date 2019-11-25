namespace HotelReservation.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        public string ResID { get; set; }

        public string CustID { get; set; }

        public string RoomID { get; set; }
                
        public DateTime? DateOfBooking { get; set; }
                
        public DateTime? CheckInDate { get; set; }
               
        public DateTime? CheckOutDate { get; set; }

        public double? TotalPaymentDue { get; set; }

        public virtual Room Room { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
