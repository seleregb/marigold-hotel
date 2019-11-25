using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HotelReservation.Application.Models;
using HotelReservation.Interfaces;
using HotelReservation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IPaymentRepository _paymentRepo;
        private readonly IReservationRepository _reservationRepo;
        private readonly ICustomerRepository _customerRepo;
        private readonly IUserRepository _userRepo;

        public PaymentsController(IPaymentRepository paymentRepo, IReservationRepository reservationRepo,
            ICustomerRepository customerRepo, IUserRepository userRepo)
        {
            _paymentRepo = paymentRepo;
            _reservationRepo = reservationRepo;
            _customerRepo = customerRepo;
            _userRepo = userRepo;
        }

        // GET: Payments
        public async Task<ActionResult> Index()
        {
            var payments = await _paymentRepo.GetAllPayments();

            return View(payments.ToList());
        }

        // GET: Payments/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            PaymentViewModel payment = await _paymentRepo.GetSinglePaymentRecord(id);

            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }

        // GET: Payments/Create
        public async Task<ActionResult> Create(string reservationId)
        {
            var resvRecord = new ReservationViewModel();
            string currentUser = string.Empty;
            var PaymentRecord = new PaymentViewModel();

            // ensure payment only goes through with the reservation id provided
            if (reservationId != null)
            {
                resvRecord = await _reservationRepo.GetReservationRecord(reservationId);

                if (User.Identity.IsAuthenticated && (User.IsInRole(UserRoles.USER) || User.IsInRole(UserRoles.GUEST)))
                {
                    currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier); 
                }
                else if (User.Identity.IsAuthenticated && (User.IsInRole(UserRoles.ADMIN)) || User.IsInRole(UserRoles.RECEPTIONIST))
                {
                    // the user in question would be the customer with that reservation
                    var customer = await _customerRepo.GetCustomerRecord(resvRecord.CustomerID);

                    var userRecord = await _userRepo.GetSingleUserByEmail(customer.EmailAddress);

                    currentUser = userRecord.Id;
                }

                var customerRecord = await _customerRepo.GetCustomerRecordByUserId(currentUser);

                PaymentRecord = new PaymentViewModel
                {
                    CustomerID = customerRecord.CustID,
                    ReservationDetails = resvRecord,
                    MethodsOfPayment = await _paymentRepo.GetPaymentMethods(),
                    PaymentAmount = resvRecord.TotalPaymentDue,
                    ReservationID = resvRecord.ResID
                };

                return View(PaymentRecord);
            }
            else
            {
                return View(PaymentRecord);
            }
        }

        // POST: Payments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PaymentViewModel payment)
        {
            if (payment != null)
            {

                //payment.ReservationDetails = _reservationRepo.GetReservationsByCustomer(payment.CustomerID)
                //    .FirstOrDefault(x => DateTime.Compare(x.DateOfBooking.Value, DateTime.Now) >= 0);
                //var currentUser = User.Identity.GetUserId();

                //payment.CustomerID = _customerRepo.GetCustomerRecordByUserId(currentUser).CustID;

                await _paymentRepo.AddPayment(payment);

                return View("Confirmation");
            }

            //ViewBag.CustID = new SelectList(db.Customers, "CustID", "UserID", payment.CustID);
            //ViewBag.PaymentMethodID = new SelectList(db.PaymentMethods, "PaymentMethodID", "PaymentDesc", payment.PaymentMethodID);
            payment.MethodsOfPayment = await _paymentRepo.GetPaymentMethods();

            return View(payment);
        }

        //GET: Payments/Edit/5
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            PaymentViewModel payment = await _paymentRepo.GetSinglePaymentRecord(id);

            if (payment == null)
            {
                return NotFound();
            }

            //ViewBag.CustID = new SelectList(db.Customers, "CustID", "UserID", payment.CustID);
            //ViewBag.PaymentMethodID = new SelectList(db.PaymentMethods, "PaymentMethodID", "PaymentDesc", payment.PaymentMethodID);

            return View(payment);
        }

        // POST: Payments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<ActionResult> Edit(string id, PaymentViewModel payment)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            if (ModelState.IsValid)
            {
                //db.Entry(payment).State = EntityState.Modified;
                //db.SaveChanges();

                await _paymentRepo.UpdatePaymentRecord(id, payment);

                return RedirectToAction("Index");
            }

            //ViewBag.CustID = new SelectList(db.Customers, "CustID", "UserID", payment.CustID);
            //ViewBag.PaymentMethodID = new SelectList(db.PaymentMethods, "PaymentMethodID", "PaymentDesc", payment.PaymentMethodID);

            return View(payment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // GET: Payments/Delete/5
        [Authorize(Policy = "OnlyAdmins")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            _paymentRepo.DeletePayment(id);

            return RedirectToAction("Index");
        }

        // POST: Payments/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    _paymentRepo.DeletePayment(id);

        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _paymentRepo.Dispose();
            }
            base.Dispose(disposing);
        }
                
        public async Task<ActionResult> CancelReservation(string reservationId)
        {
            var reservation = reservationId;

            await _reservationRepo.DeleteReservation(reservation);

            return RedirectToAction("Index", "Reservations");
        }
    }
}