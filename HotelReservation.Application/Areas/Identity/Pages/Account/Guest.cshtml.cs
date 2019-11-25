using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HotelReservation.Application.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HotelReservation.Application.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class GuestModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        private readonly ILogger<GuestModel> _logger;

        public GuestModel(SignInManager<IdentityUser> signInManager, 
            UserManager<IdentityUser> userManager,  ILogger<GuestModel> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Guest Email")]
            public string Email { get; set; }

            //[Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                //var existingUser = _userManager.FindByNameAsync(Input.Email);

                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, "Guest@123");
                if (result.Succeeded)
                {
                    _logger.LogInformation("Guest User logged in.");

                    var identity = new[]
                            {
                                new Claim(ClaimTypes.Name, Input.Email),
                                new Claim(ClaimTypes.Role,  UserRoles.GUEST.ToUpper())
                            };

                    //var principal = new ClaimsPrincipal(identity);

                    await _userManager.AddClaimsAsync(user, identity);

                    await _userManager.AddToRoleAsync(user, UserRoles.GUEST);

                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    await _signInManager.SignInAsync(user, 
                        false, 
                        CookieAuthenticationDefaults.AuthenticationScheme);

                    return RedirectToAction("Create", "Customers");
                    //return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }


    }
}
