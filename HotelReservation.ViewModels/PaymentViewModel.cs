using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelReservation.Entities;
using HotelReservation.Utilities.ValidationObjects;

namespace HotelReservation.ViewModels
{
    public class PaymentViewModel
    {
        public string PaymentID { get; set; }

        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Payment Method is required")]
        [Display(Name = "Payment Methods")]
        public string PaymentMethodID { get; set; }

        [Required(ErrorMessage = "Card Holder's name is required")]
        [Display(Name = "Card Holder")]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+", ErrorMessage ="Should not contain numbers or special characters")]
        public string CardHolder { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Display(Name = "Total Amount")]
        [DataType(DataType.Currency)]
        public double? PaymentAmount { get; set; }

        [Required(ErrorMessage ="The card number is not valid")]
        [Display(Name = "Card Number")]
#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
        [CreditCardValidation(AcceptedCardTypes = CreditCardValidation.CardType.Visa |
            CreditCardValidation.CardType.MasterCard | CreditCardValidation.CardType.Amex,
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
            ErrorMessage = "This is not a valid credit card number")]
        [StringLength(maximumLength: 16, ErrorMessage = "Credit card number should be between 13 and 16 digits", MinimumLength = 13)]
        public string Cardnumber { get; set; }

        [Required(ErrorMessage = "CVC is required")]
        [StringLength(maximumLength: 3, ErrorMessage = "CVC should be only 3 numbers")]
        [Display(Name = "CVC")]
        public string SecurityCode { get; set; }

        [Required(ErrorMessage = "Expiry Date is required")]
        [Display(Name = "Expiry Date")]
        [RegularExpression("(0[1-9]|1[0-2])\\/[0-9]{4}", ErrorMessage ="The date must be in the format MM/YYYY")]
        public string ExpiryDate { get; set; }

        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name ="Method of Payment")]
        public string PaymentDescription { get; set; }

        public ReservationViewModel ReservationDetails { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public ICollection<PaymentMethodViewModel> MethodsOfPayment { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string ReservationID { get; set; }

        [Display(Name ="Payment Details")]
        public string PaymentDetails { get; set; }
      
    }

    public class PaymentMethodViewModel
    {
        public PaymentMethodViewModel() => Payments = new HashSet<Payment>();

        public string PaymentMethodID { get; set; }

        public string PaymentDescription { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
