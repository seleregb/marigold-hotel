using System.Collections.Generic;
using System.Threading.Tasks;
using HotelReservation.ViewModels;

namespace HotelReservation.Interfaces
{
    public interface IPaymentRepository
    {
        Task<List<PaymentViewModel>> GetAllPayments();

        Task<PaymentViewModel> GetSinglePaymentRecord(string paymentId);

        Task<bool> AddPayment(PaymentViewModel model);

        Task<bool> UpdatePaymentRecord(string paymentId, PaymentViewModel model);

        Task<bool> DeletePayment(string paymentId);

        Task<List<PaymentMethodViewModel>> GetPaymentMethods();

        void Dispose();
    }
}
