using System;
using HotelReservation.Entities;
using HotelReservation.Repositories;
using Moq;
using Xunit;

namespace HotelReservation.Test
{
    public class LocationRepoTests
    {
        private readonly HotelDbContext _context;

        public LocationRepoTests(HotelDbContext context) => _context = context;

        [Fact]
        public void GetTotalCities_returns_expected_city_count()
        {
            var mockLocationRepo = new LocationRepository(_context);

            //mockLocationRepo.Setup(locationRepo => locationRepo.GetAllCities().Result.Count);

            var result = mockLocationRepo.GetAllCities().Result.Count;

            Assert.True(result == 681);
        }
    }
}
