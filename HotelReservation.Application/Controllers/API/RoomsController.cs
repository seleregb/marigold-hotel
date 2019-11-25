using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservation.Application.Controllers.API
{
    [Route("api/[controller]/")]
    public class RoomsController : BaseController
    {
        private readonly IRoomRepository _roomRepo;
        private readonly ILogger<RoomsController> _logger;

        public RoomsController(IRoomRepository roomRepo, ILogger<RoomsController> logger)
        {
            _roomRepo = roomRepo;
            _logger = logger;

        }

        [HttpPost("GetRoomPrice")]
        public async Task<IActionResult> GetRoomPrice(string roomTypeID)
        {
            if (roomTypeID != null)
            {
                _logger.LogInformation($"Getting room price for room {roomTypeID}");

                var roomTypes = await _roomRepo.GetAllRoomTypes();
                var roomPrice = roomTypes.FirstOrDefault(x => x.RoomTypeID.Equals(roomTypeID)).Price.Value;

                return Ok(new { success = "true", data = new { price = roomPrice } });
            }

            return Ok(new { success = "false" });
        }

        [HttpGet("CalculateRoomTypePrice")]
        public async Task<IActionResult> CalculateRoomTypePrice(string roomTypeId, int roomCount)
        {
            double price;

            if (roomTypeId != null)
            {
                _logger.LogInformation($"Getting room type price for room {roomTypeId} for {roomCount} rooms");

                var roomRecord = await _roomRepo.GetRoomType(roomTypeId);

                price = (double)roomRecord.Price * roomCount;

                return Ok(new { success = "true", data = price });

            }

            return Ok(new { success = "false" });

        }

        [HttpGet("GetRoomsByRoomType")]
        public async Task<IActionResult> GetRoomsByRoomType(string roomTypeId)
        {
            if (roomTypeId != null)
            {
                _logger.LogInformation($"Getting rooms by room type {roomTypeId}");

                var rooms = await _roomRepo.GetRoomsByRoomType(roomTypeId);

                return Ok(new { success = "true", data = rooms });
            }

            return Ok(new { success = "false" });
        }

    }
}
