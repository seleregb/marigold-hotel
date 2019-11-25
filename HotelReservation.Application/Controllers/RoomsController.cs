using System;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Interfaces;
using HotelReservation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controllers
{
    [Authorize(Policy = "OnlyAdmins")]
    public class RoomsController : Controller
    {
        //private CustomerDataModel db = new CustomerDataModel();
        private readonly IRoomRepository _roomRepo;

        public RoomsController(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;

        }

        // GET: Rooms
        public async Task<ActionResult> Index()
        {
            var rooms = await _roomRepo.GetAllRooms();

            return View(rooms);
        }

        // GET: Rooms/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            RoomViewModel room = await _roomRepo.GetSingleRoomRecord(id);

            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        // GET: Rooms/Create
        public async Task<ActionResult> Create()
        {
            RoomViewModel roomData = new RoomViewModel();

            roomData.RoomTypes = await _roomRepo.GetAllRoomTypes();

            return View(roomData);
        }
        
        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoomViewModel room)
        {
            if (ModelState.IsValid)
            {
                _roomRepo.AddRoom(room);
                return RedirectToAction("Index");
            }

            return View(room);
        }

        //[Authorize]
        //[HttpPost]
        //public async Task<ActionResult> GetRoomPrice(string roomTypeID)
        //{
        //    if (roomTypeID != null)
        //    {
        //        var roomTypes = await _roomRepo.GetAllRoomTypes();
        //        var roomPrice = roomTypes.Single(x => x.RoomTypeID.Equals(roomTypeID)).Price.Value;

        //        return Json(new { success = "true", data = new { price = roomPrice } });
        //    }

        //    return Json(new { success = "false" });
        //}

        // GET: Rooms/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            
            RoomViewModel roomData = await _roomRepo.GetSingleRoomRecord(id);
            roomData.RoomTypes = await _roomRepo.GetAllRoomTypes();
            if (roomData == null)
            {
                return NotFound();
            }
            
            return View(roomData);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, RoomViewModel room)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            if (ModelState.IsValid)
            {
                _roomRepo.UpdateRoomRecord(id, room);
                return RedirectToAction("Index");
            }
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            RoomViewModel roomData = await _roomRepo.GetSingleRoomRecord(id);

            if (roomData == null)
            {
                return NotFound();
            }
            return View(roomData);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            _roomRepo.DeleteRoom(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _roomRepo.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
