using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HotelReservation.Interfaces;
using HotelReservation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controllers
{
    public class CustomersController : Controller
    {
        //private CustomerDataModel db = new CustomerDataModel();

        private readonly ICustomerRepository _customerRepo;
        private readonly ILocationRepository _locationRepo;
        private readonly IUserRepository _userRepo;

        public CustomersController(ICustomerRepository customerRepo, 
            ILocationRepository locationRepo, IUserRepository userRepo)
        {
            _customerRepo = customerRepo;
            _locationRepo = locationRepo;
            _userRepo = userRepo;

        }

        // GET: Customers
        [Authorize(Policy ="OnlyAdmins")]
        public async Task<ActionResult> Index()
        {
            IEnumerable<CustomerViewModel> customerViewModels = await _customerRepo.GetAllCustomers();
            return View(customerViewModels.ToList());
        }

        // GET: Customers/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            CustomerViewModel customerViewModel = await _customerRepo.GetCustomerRecord(id);

            if (customerViewModel == null)
            {
                return NotFound();
            }
            return View(customerViewModel);
        }

        // GET: Customers/Create
        [Authorize(Policy ="OnlyGeneralUsers")]
        public async Task<ActionResult> Create()
        {
            CustomerViewModel customerData = new CustomerViewModel();

            customerData.EmailAddress = User.FindFirstValue(ClaimTypes.Name);
            customerData.Cities = await _locationRepo.GetAllCities();
            customerData.Provinces = await _locationRepo.GetAllProvinces();

            //customerData.Countries = _locationRepo.GetAllCountries().ToList();

            return View(customerData);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "OnlyGeneralUsers")]
        public async Task<ActionResult> Create(CustomerViewModel model)
        {
            if (model != null)
            {
                model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

                await _customerRepo.AddCustomerRecord(model);

                return RedirectToAction("Index", "Reservations");
            }

            model.EmailAddress = User.FindFirstValue(ClaimTypes.Name);
            model.Cities = await _locationRepo.GetAllCities();
            model.Provinces = await _locationRepo.GetAllProvinces();

            return View(model);
        }


        // GET: Customers/Create
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> CreateCustomer()
        {
            CustomerViewModel customerData = new CustomerViewModel();

            //customerData.EmailAddress = User.Identity.GetUserName();
            customerData.Cities = await _locationRepo.GetAllCities();
            customerData.Provinces = await _locationRepo.GetAllProvinces();

            //customerData.Countries = _locationRepo.GetAllCountries().ToList();

            return View(customerData);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> CreateCustomer(CustomerViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                //var guestAccountCreated = await _userRepo.GetSingleUserByEmail(model.EmailAddress);

                //if (guestAccountCreated != null)
                //{
                //    model.UserID = guestAccountCreated.Id;
                //    model.EmailAddress = guestAccountCreated.Email;
                //}

                await _customerRepo.AddCustomerRecord(model);

                return RedirectToAction("Index", "Customers");
            }

            ModelState.AddModelError(string.Empty, "There are errors in the data filled");

            model.Cities = await _locationRepo.GetAllCities();
            model.Provinces = await _locationRepo.GetAllProvinces();

            return View(model);
        }


        //GET: Customers/Edit/5
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            CustomerViewModel customerData = await _customerRepo.GetCustomerRecord(id);
            customerData.Cities = await _locationRepo.GetAllCities();

            if (customerData == null)
            {
                return NotFound();
            }

            return View(customerData);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> Edit(string id, CustomerViewModel model)
        {
            if (model != null)
            {
                await _customerRepo.UpdateCustomerRecord(id, model);

                return RedirectToAction("Index");
            }

            model.Cities = await _locationRepo.GetAllCities();

            return View(model);
        }

        [Authorize(Policy = "OnlyGeneralUsers")]
        public async Task<ActionResult> EditUserDetails(string username)
        {
            if (username == null)
            {
                return new BadRequestResult();
            }
            var existingUser = await _userRepo.GetSingleUserByEmail(username);
            CustomerViewModel customerData = await _customerRepo.GetCustomerRecordByUserId(existingUser.Id);
            customerData.Cities = await _locationRepo.GetAllCities();

            if (customerData == null)
            {
                return NotFound();
            }

            return View(customerData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "OnlyGeneralUsers")]
        public async Task<ActionResult> EditUserDetails(string id, CustomerViewModel model)
        {
            if (model != null)
            {
                await _customerRepo.UpdateCustomerRecord(id, model);

                return RedirectToAction("Index","Reservations");
            }

            var userEmail = User.FindFirstValue(ClaimTypes.Name);

            var existingUser = await _userRepo.GetSingleUserByEmail(userEmail);
            CustomerViewModel customerData = await _customerRepo.GetCustomerRecordByUserId(existingUser.Id);
            customerData.Cities = await _locationRepo.GetAllCities();

            return View(model);
        }

        // GET: Customers/Delete/5
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            CustomerViewModel customerViewModel = await _customerRepo.GetCustomerRecord(id);

            if (customerViewModel == null)
            {
                return NotFound();
            }
            return View(customerViewModel);


        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            await _customerRepo.DeleteCustomerRecord(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _customerRepo.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
