using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservation.Application.Controllers.API
{
    [Route("api/[controller]/")]
    public class AccountsController : BaseController
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(UserManager<IdentityUser> userManager, ILogger<AccountsController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }


        [HttpPost]
        public async Task<IActionResult> CreateGuestAccount(string emailAddress)
        {
            var user = new IdentityUser { UserName = emailAddress, Email = emailAddress };

            var result = await _userManager.CreateAsync(user, "Guest@123");

            if (result.Succeeded)
            {
                _logger.LogInformation("Creating guest account");

                await _userManager.AddToRoleAsync(user, UserRoles.GUEST);

                return Ok(new { success = "true", data = user.Id });
            }

            return Ok(new { success = "false" });
        }
    }
}
