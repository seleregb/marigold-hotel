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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly HotelDbContext _context;

        public CustomerRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddCustomerRecord(CustomerViewModel model)
        {

            try
            {
                Customer newCustomerRecord = new Customer();

                newCustomerRecord.CityID = Guid.NewGuid().ToString();
                newCustomerRecord.UserID = model.UserID;
                newCustomerRecord.FirstName = model.FirstName;
                newCustomerRecord.LastName = model.LastName;
                newCustomerRecord.StreetNumber = model.StreetNumber;
                newCustomerRecord.Address = model.Address;
                newCustomerRecord.CityID = model.CityID;
                newCustomerRecord.PostalCode = model.PostalCode;
                newCustomerRecord.PhoneNumber = model.PhoneNumber;
                newCustomerRecord.EmailAddress = model.EmailAddress;

                await _context.Customers.AddAsync(newCustomerRecord);

                return await _context.SaveChangesAsync() > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> DeleteCustomerRecord(string custId)
        {
            try
            {
                Customer CustomerRecord = await _context.Customers.FindAsync(custId);

                if (CustomerRecord != null)
                {
                    _context.Customers.Remove(CustomerRecord);

                    return await _context.SaveChangesAsync() > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateCustomerRecord(string custId, CustomerViewModel model)
        {
            try
            {

                if (custId != null)
                {

                    Customer customerRecord = await _context.Customers.FindAsync(custId);

                    if (customerRecord != null)
                    {
                        customerRecord.CustID = model.CustID;
                        customerRecord.UserID = model.UserID;
                        customerRecord.FirstName = model.FirstName;
                        customerRecord.LastName = model.LastName;
                        customerRecord.StreetNumber = model.StreetNumber;
                        customerRecord.Address = model.Address;
                        customerRecord.CityID = model.CityID;
                        customerRecord.PostalCode = model.PostalCode;
                        customerRecord.PhoneNumber = model.PhoneNumber;
                        customerRecord.EmailAddress = model.EmailAddress;

                        return await _context.SaveChangesAsync() > 0;
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

        public async Task<List<CustomerViewModel>> GetAllCustomers()
        {
            try
            {
                List<CustomerViewModel> customerData = await (from p in _context.Customers.AsQueryable()
                                                              select new CustomerViewModel()
                                                              {
                                                                  CustID = p.CustID,
                                                                  UserID = p.UserID,
                                                                  FirstName = p.FirstName,
                                                                  LastName = p.LastName,
                                                                  StreetNumber = p.StreetNumber,
                                                                  Address = p.Address,
                                                                  CityID = p.CityID,
                                                                  CityName = p.City.CityName,
                                                                  PostalCode = p.PostalCode,
                                                                  ProvinceName = p.City.Province.ProvinceName,
                                                                  CountryName = p.City.Province.Country.CountryName,
                                                                  PhoneNumber = p.PhoneNumber,
                                                                  EmailAddress = p.EmailAddress
                                                              }).ToAsyncEnumerable().ToList();

                return customerData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<CustomerViewModel> GetCustomerRecord(string custId)
        {
            try
            {
                Customer customerData = await _context.Customers.FindAsync(custId);

                if (customerData != null)
                {
                    return new CustomerViewModel()
                    {
                        CustID = customerData.CustID,
                        UserID = customerData.UserID,
                        FirstName = customerData.FirstName,
                        LastName = customerData.LastName,
                        StreetNumber = customerData.StreetNumber,
                        Address = customerData.Address,
                        CityID = customerData.CityID,
                        CityName = customerData.City?.CityName,
                        PostalCode = customerData.PostalCode,
                        ProvinceName = customerData.City?.Province?.ProvinceName,
                        CountryName = customerData.City?.Province?.Country?.CountryName,
                        PhoneNumber = customerData.PhoneNumber,
                        EmailAddress = customerData.EmailAddress
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<CustomerViewModel> GetCustomerRecordByUserId(string userId)
        {
            try
            {
                Customer customerData = new Customer();

                if (userId != null)
                {
                    customerData = await _context.Customers.FirstOrDefaultAsync(x => x.UserID == userId);
                }

                if (customerData != null)
                {
                    return new CustomerViewModel()
                    {
                        CustID = customerData.CustID,
                        UserID = customerData.UserID,
                        FirstName = customerData.FirstName,
                        LastName = customerData.LastName,
                        StreetNumber = customerData.StreetNumber,
                        Address = customerData.Address,
                        CityID = customerData.CityID,
                        CityName = customerData.City?.CityName,
                        PostalCode = customerData.PostalCode,
                        ProvinceName = customerData.City?.Province?.ProvinceName,
                        CountryName = customerData.City?.Province?.Country?.CountryName,
                        PhoneNumber = customerData.PhoneNumber,
                        EmailAddress = customerData.EmailAddress
                    };
                }

                return null;
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
