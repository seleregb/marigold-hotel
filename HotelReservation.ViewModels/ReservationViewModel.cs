using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;
using HotelReservation.Utilities.ValidationObjects;

namespace HotelReservation.ViewModels
{
    public class ReservationViewModel : IValidatableObject
    {
        public string ResID { get; set; }

        [Display(Name = "Customer")]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Room Number is required")]
        [Display(Name ="Room #")]
        public string RoomID { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Room Type is required")]
        [Display(Name ="Room Type")]
        public string RoomTypeID { get; set; }

        [Display(Name = "Room Type")]
        public string RoomTypeName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Booking")]
        public DateTime? DateOfBooking { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Time of Booking")]
        public string TimeOfBooking { get; set; }

        [Required(ErrorMessage = "Check In Date is required")]
        [Display(Name = "Check In Date")]
        [FutureDateValidation]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CheckInDate { get; set; }

        [Required(ErrorMessage = "Check Out Date is required")]
        [Display(Name = "Check Out Date")]
        [FutureDateValidation]
        [DataType(DataType.Date,ErrorMessage = "Invalid Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CheckOutDate { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Display(Name = "Total Amount")]
        [DataType(DataType.Currency)]
        public double? TotalPaymentDue { get; set; }

        [Required(ErrorMessage = "# of Guest is required")]
        [Display(Name = "# of Guests")]
        public int NumberOfGuests { get; set; }

        [Required(ErrorMessage = "# of Rooms is required")]
        [Display(Name = "# of Rooms")]
        public int NumberOfRooms { get; set; }

        public IEnumerable<RoomViewModel> Rooms { get; set; }

        public IEnumerable<RoomTypeViewModel> RoomTypes { get; set; }

        public virtual Room Room { get; set; }

        public virtual Customer Customer { get; set; }

        public IEnumerable<CustomerViewModel> Customers { get; set; }

        public bool RoomReserved { get; set; }

        // Validate check-in date
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            List<ValidationResult> res = new List<ValidationResult>();

            int comparison = DateTime.Compare((DateTime)CheckOutDate, (DateTime)CheckInDate);

            if (comparison < 0)
            {
                ValidationResult mss = new ValidationResult("checkout date must not be earlier than check-in date");

                res.Add(mss);
            }

            return res;
        }
    }
}
