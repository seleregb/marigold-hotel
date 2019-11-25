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
    public class LocationRepository : ILocationRepository
    {
        private readonly HotelDbContext _context;

        public LocationRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<List<CityViewModel>> GetAllCities()
        {
            try
            {
                var cityData = await (from p in _context.Cities
                                      select new CityViewModel()
                                      {
                                          CityID = p.CityID,
                                          CityName = p.CityName,
                                          ProvinceName = p.Province.ProvinceName,
                                      }).OrderBy(x => x.CityName).ToListAsync();

                return cityData;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<List<CountryViewModel>> GetAllCountries()
        {
            try
            {
                var countryData = await (from p in _context.Countries.AsQueryable()
                                         select new CountryViewModel()
                                         {
                                             CountryID = p.CountryID,
                                             CountryName = p.CountryName
                                         }).ToAsyncEnumerable().ToList();

                return countryData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<ProvinceViewModel>> GetAllProvinces()
        {
            try
            {
                var provinceData = await (from p in _context.Provinces.AsQueryable()
                                          select new ProvinceViewModel()
                                          {
                                              ProvinceID = p.ProvinceID,
                                              ProvinceName = p.ProvinceName,
                                              CountryID = p.CountryID,
                                              CountryName = p.Country.CountryName,
                                          }).ToAsyncEnumerable().ToList();

                return provinceData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<CityViewModel>> GetCitiesbyProvince(string provinceId)
        {
            try
            {
                var cityByProvinceData = await (from p in _context.Cities.AsQueryable()
                                                where p.ProvinceID.Equals(provinceId)
                                                select new CityViewModel()
                                                {
                                                    CityID = p.CityID,
                                                    CityName = p.CityName,
                                                    ProvinceID = p.ProvinceID,
                                                    ProvinceName = p.Province.ProvinceName,
                                                }).ToAsyncEnumerable().ToList();

                return cityByProvinceData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<CountryViewModel> GetCountry(string countryId)
        {
            try
            {
                var countryRecord = await _context.Countries.FindAsync(countryId);

                if (countryRecord != null)
                {
                    return new CountryViewModel()
                    {
                        CountryID = countryRecord.CountryID,
                        CountryName = countryRecord.CountryName
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<CountryViewModel> GetCountryByProvince(string provinceId)
        {
            try
            {
                var countryByProvinceData = await (from c in _context.Countries.AsQueryable()
                                                   join p in _context.Provinces on c.CountryID equals p.CountryID
                                                   where p.ProvinceID == provinceId
                                         //where p.Provinces.Select(x => x.ProvinceID).ToList().Contains(provinceId)
                                         select new CountryViewModel()
                                         {
                                             CountryID = c.CountryID,
                                             CountryName = c.CountryName
                                         }).FirstOrDefaultAsync();

                return countryByProvinceData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public async Task<ProvinceViewModel> GetProvince(string provinceId)
        {
            try
            {
                var provinceRecord = await _context.Provinces.FindAsync(provinceId);

                if (provinceRecord != null)
                {
                    return new ProvinceViewModel()
                    {
                        ProvinceID = provinceRecord.ProvinceID,
                        ProvinceName = provinceRecord.ProvinceName,
                        CountryID = provinceRecord.CountryID,
                        CountryName = provinceRecord.Country.CountryName
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<ProvinceViewModel>> GetProvincesByCity(string cityId)
        {
            try
            {
                var provinceByCityData = await (from p in _context.Provinces.AsQueryable()
                                                join c in _context.Cities on p.ProvinceID equals c.ProvinceID
                                                where c.CityID == cityId
                                          //where p.Cities.Select(x => x.CityID).Contains(cityId)
                                          select new ProvinceViewModel()
                                          {
                                              ProvinceID = p.ProvinceID,
                                              ProvinceName = p.ProvinceName,
                                              CountryID = p.CountryID,
                                              CountryName = p.Country.CountryName
                                          }).ToAsyncEnumerable().ToList();

                return provinceByCityData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<ProvinceViewModel>> GetProvincesByCountry(string countryId)
        {
            try
            {
                var provinceByCountryData = await (from p in _context.Provinces.AsQueryable()
                                                   where p.Country.CountryID.Equals(countryId)
                                                   select new ProvinceViewModel()
                                                   {
                                                       ProvinceID = p.ProvinceID,
                                                       ProvinceName = p.ProvinceName,
                                                       CountryID = p.CountryID,
                                                       CountryName = p.Country.CountryName
                                                   }).ToAsyncEnumerable().ToList();

                return provinceByCountryData;
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
