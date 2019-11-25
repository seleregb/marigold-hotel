using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Entities
{
    public class HotelDbContext : IdentityDbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.HasDefaultSchema("reservation");

            builder.Entity<ApplicationUser>()
                .Property(p => p.IsGuest)
                .HasDefaultValue(0);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.ApplicationUser)
                //.WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.UserID);

            builder.Entity<City>()
                .HasMany(e => e.Customers)
                .WithOne(e => e.City)
                .IsRequired(true)
                //.WithRequired(e => e.City)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Country>()
                .HasMany(e => e.Provinces)
                .WithOne(e => e.Country)
                .IsRequired(true)
                //.WithRequired(e => e.Country)
                //.WillCascadeOnDelete(false);
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Customer>()
                .HasMany(e => e.Payments)
                .WithOne(e => e.Customer)
                .IsRequired(true)
                //.WithRequired(e => e.Customer)
                //.WillCascadeOnDelete(false);
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<PaymentMethod>()
                .HasMany(e => e.Payments)
                .WithOne(e => e.PaymentMethod)
                .IsRequired(true)
                //.WithRequired(e => e.PaymentMethod)
                //.WillCascadeOnDelete(false);
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Province>()
                .HasMany(e => e.Cities)
                .WithOne(e => e.Province)
                .IsRequired(true)
                //.WithRequired(e => e.Province)
                //.WillCascadeOnDelete(false);
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Room>()
                .HasMany(e => e.Reservations)
                .WithOne(e => e.Room)
                .IsRequired(true)
                //.WithRequired(e => e.Room)
                //.WillCascadeOnDelete(false);
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<RoomType>()
                .HasMany(e => e.Rooms)
                .WithOne(e => e.RoomType)
                //.WithRequired(e => e.RoomType)
                .IsRequired(true)
                //.WillCascadeOnDelete(false);
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
