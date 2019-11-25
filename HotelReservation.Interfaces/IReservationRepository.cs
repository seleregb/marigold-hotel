using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelReservation.ViewModels;

namespace HotelReservation.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<ReservationViewModel>> GetAllReservations();

        Task<List<ReservationViewModel>> GetReservationsByCustomer(string customerId);

        Task<List<ReservationViewModel>> GetCurrentReservationsByCustomer(ReservationViewModel model);

        Task<List<ReservationViewModel>> GetReservationsByUser(string userId);

        Task<List<ReservationViewModel>> GetReservationsByBookingDate(DateTime bookingDate);

        Task<List<ReservationViewModel>> GetAllReservationsByRoom(string roomId);

        Task<ReservationViewModel> GetReservationRecord(string reservationId);

        Task<bool> AddNewReservation(ReservationViewModel model);

        Task<bool> UpdateReservation(string reservationId, ReservationViewModel model);

        Task<bool> DeleteReservation(string reservationId);

        void Dispose();
    }
}