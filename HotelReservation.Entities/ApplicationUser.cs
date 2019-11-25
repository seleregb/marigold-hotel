using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HotelReservation.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser() => Customers = new HashSet<Customer>();

        public new string Id { get; set; }

        public new string Email { get; set; }

        public new string UserName { get; set; }

        public bool IsGuest { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
