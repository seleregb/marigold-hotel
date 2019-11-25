using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Entities;
using HotelReservation.Interfaces;
using HotelReservation.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        //private readonly string BASE_URL = "http://localhost:8080/HotelRestClient/rest/reservations";

        private readonly HotelDbContext _context;

        public ReservationRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddNewReservation(ReservationViewModel model)
        {
            try
            {
                RoomType roomRecord = await _context.RoomTypes.AsQueryable()
                    .Where(x => x.Rooms.Select(z => z.RoomID)
                    .Contains(model.RoomID)).FirstOrDefaultAsync();

                Reservation newRvRecord = new Reservation()
                {
                    ResID = Guid.NewGuid().ToString(),
                    CustID = model.CustomerID,
                    RoomID = model.RoomID,
                    DateOfBooking = DateTime.Now,
                    CheckInDate = model.CheckInDate,
                    CheckOutDate = model.CheckOutDate,
                    //TimeOfBooking = DateTime.Now.ToShortTimeString(),
                    TotalPaymentDue = model.TotalPaymentDue
                    //TotalPaymentDue = roomRecord.Price * model.NumberOfRooms
                };

                await _context.Reservations.AddAsync(newRvRecord);

                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> DeleteReservation(string reservationId)
        {
            try
            {
                Reservation reserveRecord = await _context.Reservations.FindAsync(reservationId);

                if (reserveRecord != null)
                {
                    _context.Reservations.Remove(reserveRecord);

                    return _context.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<List<ReservationViewModel>> GetAllReservations()
        {
            try
            {
                List<ReservationViewModel> reservationData = await (from r in _context.Reservations.AsQueryable()
                                                                    join c in _context.Customers on r.CustID equals c.CustID
                                                                    select new ReservationViewModel()
                                                                    {
                                                                        ResID = r.ResID,
                                                                        CustomerID = r.CustID,
                                                                        CustomerName = c.FirstName + " " + c.LastName,
                                                                        RoomID = r.RoomID,
                                                                        RoomTypeName = r.Room.RoomType.TypeDesc,
                                                                        DateOfBooking = (DateTime)r.DateOfBooking,
                                                                        CheckInDate = (DateTime)r.CheckInDate,
                                                                        CheckOutDate = (DateTime)r.CheckOutDate,
                                                                        //TimeOfBooking = r.TimeOfBooking,
                                                                        TotalPaymentDue = r.TotalPaymentDue,
                                                                        RoomReserved = r.Room.Reserved
                                                                    }).OrderByDescending(x => x.DateOfBooking).ToAsyncEnumerable().ToList();

                return reservationData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<ReservationViewModel>> GetAllReservationsByRoom(string roomId)
        {
            try
            {
                List<ReservationViewModel> reservationData = await (from r in _context.Reservations.AsQueryable()
                                                                    where r.RoomID.Equals(roomId)
                                                                    select new ReservationViewModel()
                                                                    {
                                                                        ResID = r.ResID,
                                                                        CustomerID = r.CustID,
                                                                        RoomID = r.RoomID,
                                                                        RoomTypeName = r.Room.RoomType.TypeDesc,
                                                                        DateOfBooking = (DateTime)r.DateOfBooking,
                                                                        CheckOutDate = (DateTime)r.CheckOutDate,
                                                                        CheckInDate = (DateTime)r.CheckInDate,
                                                                        //TimeOfBooking = r.TimeOfBooking,
                                                                        TotalPaymentDue = r.TotalPaymentDue,
                                                                        RoomReserved = r.Room.Reserved
                                                                    }).ToAsyncEnumerable().ToList();

                return reservationData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<ReservationViewModel> GetReservationRecord(string reservationId)
        {

            try
            {
                ReservationViewModel reservationRecord = await (from r in _context.Reservations.AsQueryable()
                                                                join c in _context.Customers on r.CustID equals c.CustID
                                                                where r.ResID == reservationId
                                                                select new ReservationViewModel()
                                                                {
                                                                    ResID = r.ResID,
                                                                    CustomerID = r.CustID,
                                                                    CustomerName = c.FirstName + " " + c.LastName,
                                                                    RoomID = r.RoomID,
                                                                    RoomTypeName = r.Room.RoomType.TypeDesc,
                                                                    DateOfBooking = (DateTime)r.DateOfBooking,
                                                                    CheckOutDate = (DateTime)r.CheckOutDate,
                                                                    CheckInDate = (DateTime)r.CheckInDate,
                                                                    //TimeOfBooking = r.TimeOfBooking,
                                                                    TotalPaymentDue = r.TotalPaymentDue,
                                                                    RoomReserved = r.Room.Reserved
                                                                }).FirstOrDefaultAsync();

                if (reservationRecord != null)
                {
                    return reservationRecord;
                }

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<List<ReservationViewModel>> GetReservationsByCustomer(string customerId)
        {
            try
            {
                var reservationData = await (from r in _context.Reservations
                                             where r.CustID == customerId
                                             select new ReservationViewModel()
                                             {
                                                 ResID = r.ResID,
                                                 CustomerID = r.CustID,
                                                 CustomerName = r.Customer.FirstName + " " + r.Customer.LastName,
                                                 RoomID = r.RoomID,
                                                 RoomTypeName = r.Room.RoomType.TypeDesc,
                                                 DateOfBooking = (DateTime)r.DateOfBooking,
                                                 CheckOutDate = (DateTime)r.CheckOutDate,
                                                 CheckInDate = (DateTime)r.CheckInDate,
                                                 RoomTypeID = r.Room.RoomTypeID,
                                                 //TimeOfBooking = r.TimeOfBooking,
                                                 TotalPaymentDue = r.TotalPaymentDue,
                                                 RoomReserved = r.Room.Reserved
                                             }).ToAsyncEnumerable().ToList();

                return reservationData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<ReservationViewModel>> GetCurrentReservationsByCustomer(ReservationViewModel model)
        {
            try
            {
                var reservationData = await (from r in _context.Reservations
                                             where r.CustID == model.CustomerID
                                             && r.RoomID == model.RoomID
                                             //&& DateTime.Now.CompareTo(r.DateOfBooking.Value) >= 0
                                             //&& r.Room.RoomTypeID == model.RoomTypeID
                                             select new ReservationViewModel()
                                             {
                                                 ResID = r.ResID,
                                                 CustomerID = r.CustID,
                                                 CustomerName = r.Customer.FirstName + " " + r.Customer.LastName,
                                                 RoomID = r.RoomID,
                                                 RoomTypeName = r.Room.RoomType.TypeDesc,
                                                 DateOfBooking = (DateTime)r.DateOfBooking,
                                                 CheckOutDate = (DateTime)r.CheckOutDate,
                                                 CheckInDate = (DateTime)r.CheckInDate,
                                                 RoomTypeID = r.Room.RoomTypeID,
                                                 //TimeOfBooking = r.TimeOfBooking,
                                                 TotalPaymentDue = r.TotalPaymentDue,
                                                 RoomReserved = r.Room.Reserved
                                             }).ToAsyncEnumerable().ToList();

                return reservationData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<ReservationViewModel>> GetReservationsByUser(string userId)
        {
            try
            {
                var reservationData = await (from r in _context.Reservations
                                             join c in _context.Customers on r.CustID equals c.CustID
                                             where c.UserID == userId
                                             select new ReservationViewModel()
                                             {
                                                 ResID = r.ResID,
                                                 CustomerID = r.CustID,
                                                 CustomerName = c.FirstName + " " + c.LastName,
                                                 RoomID = r.RoomID,
                                                 RoomTypeName = r.Room.RoomType.TypeDesc,
                                                 DateOfBooking = (DateTime)r.DateOfBooking,
                                                 CheckOutDate = (DateTime)r.CheckOutDate,
                                                 CheckInDate = (DateTime)r.CheckInDate,
                                                 //TimeOfBooking = r.TimeOfBooking,
                                                 TotalPaymentDue = r.TotalPaymentDue,
                                                 RoomReserved = r.Room.Reserved
                                             }).ToAsyncEnumerable().ToList();

                return reservationData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> UpdateReservation(string reservationId, ReservationViewModel model)
        {
            try
            {
                if (reservationId != null)
                {

                    Reservation reservationRecord = await _context.Reservations.FindAsync(reservationId);

                    if (reservationRecord != null)
                    {
                        reservationRecord.RoomID = model.RoomID;
                        reservationRecord.DateOfBooking = model.DateOfBooking;
                        reservationRecord.CheckOutDate = model.CheckOutDate;
                        reservationRecord.CheckInDate = model.CheckInDate;
                        //reservationRecord.TimeOfBooking = model.TimeOfBooking;
                        reservationRecord.TotalPaymentDue = model.TotalPaymentDue;

                        return _context.SaveChanges() > 0;
                    }

                    return false;

                }

                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<ReservationViewModel>> GetReservationsByBookingDate(DateTime bookingDate)
        {
            var reservationData = await (from r in _context.Reservations
                                         join c in _context.Customers on r.CustID equals c.CustID
                                         where r.DateOfBooking.Equals(bookingDate)
                                         select new ReservationViewModel()
                                         {
                                             ResID = r.ResID,
                                             CustomerID = r.CustID,
                                             CustomerName = c.FirstName + " " + c.LastName,
                                             RoomID = r.RoomID,
                                             RoomTypeName = r.Room.RoomType.TypeDesc,
                                             DateOfBooking = r.DateOfBooking,
                                             CheckOutDate = r.CheckOutDate,
                                             CheckInDate = r.CheckInDate,
                                             //TimeOfBooking = r.TimeOfBooking,
                                             TotalPaymentDue = r.TotalPaymentDue,
                                             RoomReserved = r.Room.Reserved
                                         }).ToAsyncEnumerable().ToList();

            return reservationData;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
