namespace HotelReservation.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Room")]
    public class Room
    {
        public Room() => Reservations = new HashSet<Reservation>();

        public string RoomID { get; set; }

        public string RoomTypeID { get; set; }

        public int? RoomNumber { get; set; }

        public bool Reserved { get; set; }

        public int? Floor { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual RoomType RoomType { get; set; }
             
    }
}
