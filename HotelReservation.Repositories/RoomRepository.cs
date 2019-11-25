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
    public class RoomRepository : IRoomRepository
    {
        private readonly HotelDbContext _context;

        public RoomRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddRoom(RoomViewModel model)
        {
            try
            {
                Room newRoomRecord = new Room()
                {
                    RoomID = Guid.NewGuid().ToString(),
                    RoomTypeID = model.RoomTypeID,
                    RoomNumber = model.RoomNumber,
                    Reserved = model.Reserved,
                    Floor = model.Floor
                };

                await _context.Rooms.AddAsync(newRoomRecord);

                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<bool> DeleteRoom(string roomId)
        {
            try
            {
                Room RoomRecord = await _context.Rooms.FindAsync(roomId);

                if (RoomRecord != null)
                {
                    _context.Rooms.Remove(RoomRecord);

                    return _context.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> UpdateRoomRecord(string roomId, RoomViewModel model)
        {
            try
            {
                if (roomId != null)
                {

                    Room RoomRecord = await _context.Rooms.FindAsync(roomId);

                    if (RoomRecord != null)
                    {
                        RoomRecord.RoomTypeID = model.RoomTypeID;
                        RoomRecord.RoomNumber = model.RoomNumber;
                        RoomRecord.Reserved = model.Reserved;
                        RoomRecord.Floor = model.Floor;

                        return _context.SaveChanges() > 0;
                    }

                    return false;

                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<RoomViewModel>> GetAllRooms()
        {
            try
            {
                var roomData = await (from p in _context.Rooms.AsQueryable()
                                select new RoomViewModel()
                                {
                                    RoomID = p.RoomID,
                                    RoomTypeID = p.RoomTypeID,
                                    RoomTypeName = p.RoomType.TypeDesc,
                                    RoomNumber = p.RoomNumber,
                                    Reserved = p.Reserved,
                                    Price = p.RoomType.Price,
                                    Floor = p.Floor
                                }).ToAsyncEnumerable().ToList();

                return roomData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<RoomViewModel> GetSingleRoomRecord(string roomId)
        {
            try
            {
                var RoomRecord = await _context.Rooms.FindAsync(roomId);

                if (RoomRecord != null)
                {
                    return new RoomViewModel()
                    {
                        RoomID = RoomRecord.RoomID,
                        RoomTypeID = RoomRecord.RoomTypeID,
                        RoomTypeName = RoomRecord.RoomType.TypeDesc,
                        RoomNumber = RoomRecord.RoomNumber,
                        Reserved = RoomRecord.Reserved,
                        Floor = RoomRecord.Floor,
                        Price = RoomRecord.RoomType.Price
                    };
                }

                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<RoomTypeViewModel>> GetAllRoomTypes()
        {
            try
            {
                var roomData = await (from p in _context.RoomTypes.AsQueryable()
                                select new RoomTypeViewModel()
                                {
                                    RoomTypeID = p.RoomTypeID,
                                    TypeDescription = p.TypeDesc,
                                    Price = p.Price
                                }).ToAsyncEnumerable().ToList();

                return roomData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<RoomTypeViewModel> GetRoomType(string roomTypeId)
        {
            try
            {
                var roomData = await (from p in _context.RoomTypes.AsQueryable()
                                where p.RoomTypeID == roomTypeId
                                select new RoomTypeViewModel()
                                {
                                    RoomTypeID = p.RoomTypeID,
                                    TypeDescription = p.TypeDesc,
                                    Price = p.Price
                                }).FirstOrDefaultAsync();

                return roomData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<RoomViewModel>> GetRoomsByRoomType(string roomTypeId)
        {
            try
            {
                var roomData = await (from p in _context.Rooms.AsQueryable()
                                where p.RoomTypeID.Equals(roomTypeId) &&
                                p.Reserved == false
                                select new RoomViewModel()
                                {
                                    RoomID = p.RoomID,
                                    RoomTypeID = p.RoomTypeID,
                                    RoomTypeName = p.RoomType.TypeDesc,
                                    RoomNumber = p.RoomNumber,
                                    Reserved = p.Reserved,
                                    Price = p.RoomType.Price,
                                    Floor = p.Floor
                                }).ToAsyncEnumerable().ToList();

                return roomData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
