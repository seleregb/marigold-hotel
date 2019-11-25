using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;

namespace HotelReservation.ViewModels
{
    public class RoomViewModel
    {
        public RoomViewModel() => Reservations = new HashSet<Reservation>();

        public string RoomID { get; set; }

        [Required(ErrorMessage = "Room Type is required")]
        [Display(Name = "Room Type")]
        public string RoomTypeID { get; set; }

        [Required]
        [Range(1, double.MaxValue,ErrorMessage ="Please Enter Valid Amount")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Floor is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please Enter Valid Floor")]
        public int? Floor { get; set; }

        [Required(ErrorMessage = "Room Type is required")]
        [Display(Name = "Room Type")]
        public string RoomTypeName { get; set; }

        [Required(ErrorMessage = "Room number is required")]
        [Display(Name = "Room Number")]
        [Range(1, int.MaxValue, ErrorMessage = "Please Enter Valid room number")]
        public int? RoomNumber { get; set; }

        [Required]
        public bool Reserved { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual RoomType RoomType { get; set; }

        public IEnumerable<RoomTypeViewModel> RoomTypes { get; set; }
    }

    public class RoomTypeViewModel
    {
        public RoomTypeViewModel() => Rooms = new HashSet<Room>();

        public string RoomTypeID { get; set; }
                
        public string TypeDescription { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please Enter Valid Amount")]
        public double? Price { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
