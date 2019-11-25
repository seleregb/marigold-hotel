using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HotelReservation.Application.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace HotelReservation.Application.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Access Level")]
            public string AccessLevel { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

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
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    IEnumerable<Claim> identityClaims = new List<Claim>();
                    ClaimsPrincipal principal = new ClaimsPrincipal();

                    switch (Input.AccessLevel)
                    {
                        case "Admin":
                            identityClaims = new[]
                            {
                                new Claim(ClaimTypes.Name, Input.Email),
                                new Claim(ClaimTypes.Role,  UserRoles.ADMIN.ToUpper())
                            };

                            //principal = new ClaimsPrincipal(identity);

                            await _userManager.AddClaimsAsync(user, identityClaims);

                            await _userManager.AddToRoleAsync(user, UserRoles.ADMIN);

                            //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                            // await _signInManager.SignInAsync(user, false, 
                            //     CookieAuthenticationDefaults.AuthenticationScheme);

                            return RedirectToAction("Index", "Reservations");

                            //break;

                        case "Receptionist":
                            identityClaims = new[]
                            {
                                new Claim(ClaimTypes.Name, Input.Email),
                                new Claim(ClaimTypes.Role,  UserRoles.RECEPTIONIST.ToUpper())
                            };

                            //principal = new ClaimsPrincipal(identity);

                            await _userManager.AddClaimsAsync(user, identityClaims);

                            await _userManager.AddToRoleAsync(user, UserRoles.RECEPTIONIST);

                            //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                            // await _signInManager.SignInAsync(user, false, 
                            //     CookieAuthenticationDefaults.AuthenticationScheme);

                            return RedirectToAction("Index", "Reservations");

                        //break;
                        default:
                            identityClaims = new[]
                            {
                                new Claim(ClaimTypes.Name, Input.Email),
                                new Claim(ClaimTypes.Role,  UserRoles.USER.ToUpper())
                            };

                            //principal = new ClaimsPrincipal(identityClaims);

                            await _userManager.AddClaimsAsync(user, identityClaims);

                            await _userManager.AddToRoleAsync(user, UserRoles.USER);

                            //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                            // await _signInManager.SignInAsync(user, false, 
                            //     CookieAuthenticationDefaults.AuthenticationScheme);

                            return RedirectToAction("Create", "Customers");
                    }

                    //await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, UserRoles.USER));

                    //await _userManager.AddToRoleAsync(user, UserRoles.USER);

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { userId = user.Id, code = code },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        //$"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    //return RedirectToAction("Create", "Customers");
                    //return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
