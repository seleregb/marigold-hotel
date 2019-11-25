using System.Collections.Generic;
using System.Threading.Tasks;
using HotelReservation.ViewModels;

namespace HotelReservation.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<RoomViewModel>> GetAllRooms();

        Task<RoomViewModel> GetSingleRoomRecord(string RoomID);

        Task<bool> AddRoom(RoomViewModel model);

        Task<bool> UpdateRoomRecord(string RoomId, RoomViewModel model);

        Task<bool> DeleteRoom(string RoomId);

        Task<List<RoomTypeViewModel>> GetAllRoomTypes();

        Task<List<RoomViewModel>> GetRoomsByRoomType(string roomTypeId);

        Task<RoomTypeViewModel> GetRoomType(string roomTypeId);

        void Dispose();
    }
}
