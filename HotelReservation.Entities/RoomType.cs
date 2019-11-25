namespace HotelReservation.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RoomType")]
    public class RoomType
    {
        public RoomType() => Rooms = new HashSet<Room>();

        public string RoomTypeID { get; set; }

        [StringLength(250)]
        public string TypeDesc { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public double? Price { get; set; }
        
    }
}
