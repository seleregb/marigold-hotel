using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservation.Application.Controllers.API
{
    [Route("api/[controller]/")]
    public class LocationController : BaseController
    {
        private readonly ILocationRepository _locationRepo;
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILocationRepository locationRepo, ILogger<LocationController> logger)
        {
            _locationRepo = locationRepo;
            _logger = logger;
        }

        //Functions for cascading dropdown

        [HttpPost("GetProvinceByCity")]
        public async Task<IActionResult> GetProvinceByCity(string cityID)
        {
            if (cityID != null)
            {
                //CustomerViewModel customerdata = new CustomerViewModel();
                _logger.LogInformation($"Fetching provinces by city {cityID}");

                var provinces = await _locationRepo.GetProvincesByCity(cityID);
                //var roomPrice = roomTypes.Where(x => x.RoomTypeID.Equals(roomTypeID)).Single().Price.Value;
                //var provinceName = provinces.Single().ProvinceName;

                return Ok(new { success = "true", data = new { provinces } });
                //return Json(new { success = "true", data = new { province = provinceName } });
            }

            return Ok(new { success = "false" });
        }

        [HttpPost("GetCountryByProvince")]
        public async Task<IActionResult> GetCountryByProvince(string provinceID)
        {
            if (provinceID != null)
            {
                //CustomerViewModel customerdata = new CustomerViewModel();
                _logger.LogInformation($"Fetching countries by province {provinceID}");

                var countries = await _locationRepo.GetCountryByProvince(provinceID);
                //var roomPrice = roomTypes.Where(x => x.RoomTypeID.Equals(roomTypeID)).Single().Price.Value;

                return Ok(new { success = "true", data = new { countries } });
            }

            return Ok(new { success = "false" });
        }

        [HttpPost("GetProvinceByCountry")]
        public async Task<IActionResult> GetProvinceByCountry(string countryID)
        {
            if (countryID != null)
            {
                //CustomerViewModel customerdata = new CustomerViewModel();
                _logger.LogInformation($"Fetching provinces by country {countryID}");

                var provinces = await _locationRepo.GetProvincesByCountry(countryID);
                //var roomPrice = roomTypes.Where(x => x.RoomTypeID.Equals(roomTypeID)).Single().Price.Value;

                return Ok(new { success = "true", data = new { provinces } });
            }

            return Ok(new { success = "false" });
        }

        [HttpPost("GetCitiesByProvince")]
        public async Task<IActionResult> GetCitiesByProvince(string provinceID)
        {
            if (provinceID != null)
            {
                //CustomerViewModel customerdata = new CustomerViewModel();
                _logger.LogInformation($"Fetching cities by province {provinceID}");

                var cities = await _locationRepo.GetCitiesbyProvince(provinceID);
                //var roomPrice = roomTypes.Where(x => x.RoomTypeID.Equals(roomTypeID)).Single().Price.Value;

                return Ok(new { success = "true", data = new { cities } });
            }

            return Ok(new { success = "false" });
        }
    }
}
