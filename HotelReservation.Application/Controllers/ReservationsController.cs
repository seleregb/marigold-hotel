using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HotelReservation.Application.Models;
using HotelReservation.Interfaces;
using HotelReservation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelReservation.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly IReservationRepository _reserveRepo;
        private readonly IRoomRepository _roomRepo;
        private readonly ICustomerRepository _customerRepo;
        private readonly IPaymentRepository _paymentRepo;

        public ReservationsController(IReservationRepository reserveRepo,
            IRoomRepository roomRepo, ICustomerRepository CustomerRepo, IPaymentRepository paymentRepo)
        {
            _reserveRepo = reserveRepo;
            _roomRepo = roomRepo;
            _paymentRepo = paymentRepo;
            _customerRepo = CustomerRepo;
        }

        // GET: Reservations
        public async Task<ActionResult> Index()
        {
            IEnumerable<ReservationViewModel> reservations = new List<ReservationViewModel>();

            if (User.Identity.IsAuthenticated && (User.IsInRole(UserRoles.ADMIN) || User.IsInRole(UserRoles.RECEPTIONIST)))
            {
                reservations = await _reserveRepo.GetAllReservations();
            }
            else if (User.Identity.IsAuthenticated && User.IsInRole(UserRoles.USER))
            {
                var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

                reservations = await _reserveRepo.GetReservationsByUser(currentUser);
            }
            else if (User.Identity.IsAuthenticated && User.IsInRole(UserRoles.GUEST))
            {
                return RedirectToAction("MakeReservation", "Reservations");
            }

            return View(reservations.ToList());
        }

        [Authorize(Policy = "OnlyGeneralUsers")]
        public async Task<ActionResult> MakeReservation()
        {
            ReservationViewModel reservation = new ReservationViewModel
            {
                RoomTypes = await _roomRepo.GetAllRoomTypes(),
                Rooms = await _roomRepo.GetAllRooms(),
            };

            ViewBag.NumberOfGuests = GetListOfAllowedGuests();
            ViewBag.NumberOfRooms = GetListOfAllowedRooms();

            return View(reservation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> MakeReservation(ReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var customerRecord = await _customerRepo.GetCustomerRecordByUserId(currentUser);
                model.CustomerID = customerRecord.CustID;

                await _reserveRepo.AddNewReservation(model);

                var currentReservation = await _reserveRepo.GetCurrentReservationsByCustomer(model);
                var currentResID = currentReservation.FirstOrDefault(x => DateTime.Now.CompareTo(x.DateOfBooking.Value) >= 0
                && x.RoomTypeID == model.RoomTypeID).ResID;

                return RedirectToAction("Create", "Payments", new { reservationId = currentResID });
            }

            model.RoomTypes = await _roomRepo.GetAllRoomTypes();

            model.Rooms = await _roomRepo.GetAllRooms();

            ViewBag.NumberOfGuests = GetListOfAllowedGuests();
            ViewBag.NumberOfRooms = GetListOfAllowedRooms();

            return View(model);
        }

        [Authorize(Policy ="OnlyAdmins")]
        public async Task<ActionResult> Create()
        {
            ReservationViewModel reservation = new ReservationViewModel
            {
                RoomTypes = await _roomRepo.GetAllRoomTypes(),
                Rooms = await _roomRepo.GetAllRooms(),
                Customers = await _customerRepo.GetAllCustomers()
            };

            ViewBag.NumberOfGuests = GetListOfAllowedGuests();
            ViewBag.NumberOfRooms = GetListOfAllowedRooms();

            return View(reservation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ReservationViewModel model)
        {

            if (ModelState.IsValid)
            {
                await _reserveRepo.AddNewReservation(model);

                return RedirectToAction("Index");
            }

            model.RoomTypes = await _roomRepo.GetAllRoomTypes();
            model.Rooms = await _roomRepo.GetAllRooms();

            ViewBag.NumberOfGuests = GetListOfAllowedGuests();
            ViewBag.NumberOfRooms = GetListOfAllowedRooms();

            return View(model);
        }

        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            ReservationViewModel reservation = await _reserveRepo.GetReservationRecord(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [Authorize(Policy ="OnlyAdmins")]
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            ReservationViewModel reservation = await _reserveRepo.GetReservationRecord(id);

            reservation.Customers = await _customerRepo.GetAllCustomers();
            reservation.Rooms = await _roomRepo.GetAllRooms();

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, ReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                _reserveRepo.UpdateReservation(id, model);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            ReservationViewModel reservation = await _reserveRepo.GetReservationRecord(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            _reserveRepo.DeleteReservation(id);

            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public async Task<ActionResult> GetRoomsByRoomType(string roomTypeId)
        //{
        //    if (roomTypeId != null)
        //    {
        //        var rooms = await _roomRepo.GetRoomsByRoomType(roomTypeId);

        //        return Json(new { success = "true", data = rooms });
        //    }

        //    return Json(new { success = "false" });
        //}

        public async Task<ActionResult> ManageExistingReservations(string customerId)
        {
            IEnumerable<ReservationViewModel> existingReservations = new List<ReservationViewModel>();

            if (customerId != null)
            {
                existingReservations = await _reserveRepo.GetReservationsByCustomer(customerId);
            }

            ViewBag.reservationCount = existingReservations.Count();

            return View(existingReservations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _reserveRepo.Dispose();
            }
            base.Dispose(disposing);
        }

        private IEnumerable<SelectListItem> GetListOfAllowedGuests()
        {
            List<SelectListItem> allowedGuests = new List<SelectListItem>();
            for (int i = 1; i <= 10; i++)
            {
                allowedGuests.Add(new SelectListItem
                {
                    Value = i.ToString(),
                    Text = i.ToString()
                });
            }

            return allowedGuests;
        }

        private IEnumerable<SelectListItem> GetListOfAllowedRooms()
        {
            List<SelectListItem> allowedRooms = new List<SelectListItem>();
            for (int i = 1; i <= 5; i++)
            {
                allowedRooms.Add(new SelectListItem
                {
                    Value = i.ToString(),
                    Text = i.ToString()
                });
            }

            return allowedRooms;
        }

        //[HttpGet]
        //public async Task<ActionResult> CalculateRoomTypePrice(string roomTypeId, int roomCount)
        //{
        //    double price;

        //    if (roomTypeId != null)
        //    {
        //        var roomRecord = await _roomRepo.GetRoomType(roomTypeId);

        //        price = (double)roomRecord.Price * roomCount;

        //        return Json(new { success = "true", data = price });

        //    }

        //    return Json(new { success = "false" });

        //}
    }
}