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
    public class UserRepository : IUserRepository
    {
        private readonly HotelDbContext _context;

        public UserRepository(HotelDbContext context)
        {
            _context = context;
        }

        public Task<bool> CreateUserAccountByEmail(string EmailAddress)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserViewModel>> GetAllUsers()
        {
            try
            {
                var userData = await (from r in _context.ApplicationUsers.AsQueryable()
                                select new UserViewModel()
                                {
                                    Id = r.Id,
                                    Email = r.Email,
                                    UserName = r.UserName
                                }).ToAsyncEnumerable().ToList();

                return userData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<UserViewModel> GetSingleUser(string UserID)
        {
            try
            {
                var userData = await (from r in _context.ApplicationUsers
                                where r.Id.Equals(UserID)
                                select new UserViewModel()
                                {
                                    Id = r.Id,
                                    Email = r.Email,
                                    UserName = r.UserName
                                }).FirstOrDefaultAsync();
                return userData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<UserViewModel> GetSingleUserByEmail(string EmailAddress)
        {
            try
            {
                var userData = await (from r in _context.ApplicationUsers
                                where r.Email.Equals(EmailAddress)
                                select new UserViewModel()
                                {
                                    Id = r.Id,
                                    Email = r.Email,
                                    UserName = r.UserName
                                }).FirstOrDefaultAsync();
                return userData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
