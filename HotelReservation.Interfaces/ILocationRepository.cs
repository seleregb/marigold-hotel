using HotelReservation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Interfaces
{
    public interface ILocationRepository
    {
        Task<List<CityViewModel>> GetAllCities();

        Task<List<CityViewModel>> GetCitiesbyProvince(string provinceId);

        Task<List<ProvinceViewModel>> GetAllProvinces();

        Task<ProvinceViewModel> GetProvince(string provinceId);

        Task<List<ProvinceViewModel>> GetProvincesByCountry(string countryId);

        Task<List<ProvinceViewModel>> GetProvincesByCity(string cityId);

        Task<List<CountryViewModel>> GetAllCountries();

        Task<CountryViewModel> GetCountry(string countryId);

        Task<CountryViewModel> GetCountryByProvince(string provinceId);

        void Dispose();
    }
}
