using System.Collections.Generic;
using System.Threading.Tasks;
using HotelReservation.ViewModels;

namespace HotelReservation.Interfaces
{
    public interface ICustomerRepository
    {
        void Dispose();

        Task<List<CustomerViewModel>> GetAllCustomers();

        Task<CustomerViewModel> GetCustomerRecord(string CustId);

        Task<bool> AddCustomerRecord(CustomerViewModel model);

        Task<bool> UpdateCustomerRecord(string CustId, CustomerViewModel model);

        Task<bool> DeleteCustomerRecord(string CustId);

        Task<CustomerViewModel> GetCustomerRecordByUserId(string userId);
    }
}
