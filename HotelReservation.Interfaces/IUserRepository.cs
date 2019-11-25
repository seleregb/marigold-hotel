using System.Collections.Generic;
using System.Threading.Tasks;
using HotelReservation.ViewModels;

namespace HotelReservation.Interfaces
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetSingleUser(string UserID);
       
        Task<UserViewModel> GetSingleUserByEmail(string EmailAddress);
       
        Task<List<UserViewModel>> GetAllUsers();

    }
}
