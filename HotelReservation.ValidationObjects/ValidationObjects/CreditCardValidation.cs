using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HotelReservation.Utilities.ValidationObjects
{
    public class CreditCardValidation : ValidationAttribute
    {
        /**
         * Taken and modified from https://benjii.me/2010/11/credit-card-validator-attribute-for-asp-net-mvc-3/
         * */

        private CardType _cardTypes;
        public CardType AcceptedCardTypes
        {
            get { return _cardTypes; }
            set { _cardTypes = value; }
        }

        public CreditCardValidation()
        {
            _cardTypes = CardType.All;
        }

        public CreditCardValidation(CardType AcceptedCardTypes)
        {
            _cardTypes = AcceptedCardTypes;
        }

        public override bool IsValid(object value)
        {
            var number = Convert.ToString(value);

            if (String.IsNullOrEmpty(number))
                return true;

            return IsValidType(number, _cardTypes) && IsValidNumber(number);
        }

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field contains an invalid credit card number.";
        }

        public enum CardType
        {
            Unknown = 1,
            Visa = 2,
            MasterCard = 4,
            Amex = 8,

#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
            All = CardType.Visa | CardType.MasterCard | CardType.Amex,
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
            AllOrUnknown = CardType.Unknown | CardType.Visa | CardType.MasterCard | CardType.Amex
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
        }

        private bool IsValidType(string cardNumber, CardType cardType)
        {
            // Visa
            if (Regex.IsMatch(cardNumber, "^(4)")
#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                && ((cardType & CardType.Visa) != 0))
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                return cardNumber.Length == 13 || cardNumber.Length == 16;

            // MasterCard
            if (Regex.IsMatch(cardNumber, "^(51|52|53|54|55)")
#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                && ((cardType & CardType.MasterCard) != 0))
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                return cardNumber.Length == 16;

            // Amex
            if (Regex.IsMatch(cardNumber, "^(34|37)")
#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                && ((cardType & CardType.Amex) != 0))
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                return cardNumber.Length == 15;

            //Unknown
#pragma warning disable RECS0016 // Bitwise operation on enum which has no [Flags] attribute
            if ((cardType & CardType.Unknown) != 0)
#pragma warning restore RECS0016 // Bitwise operation on enum which has no [Flags] attribute
                return true;

            return false;
        }

        private bool IsValidNumber(string number)
        {
            int[] DELTAS = new int[] { 0, 1, 2, 3, 4, -4, -3, -2, -1, 0 };
            int checksum = 0;
            char[] chars = number.ToCharArray();
            for (int i = chars.Length - 1; i > -1; i--)
            {
                int j = ((int)chars[i]) - 48;
                checksum += j;
                if (((i - chars.Length) % 2) == 0)
                    checksum += DELTAS[j];
            }

            return ((checksum % 10) == 0);
        }
    }
}
