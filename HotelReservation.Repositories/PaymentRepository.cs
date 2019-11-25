using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Entities;
using HotelReservation.Interfaces;
using HotelReservation.ViewModels;

namespace HotelReservation.Repositories
{
    public class PaymentRepository:IPaymentRepository
    {
        //private readonly string BASE_URL = "http://localhost:8080/HotelRestClient/rest/payments";
        private readonly HotelDbContext _context;
        
        public PaymentRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaymentViewModel>> GetAllPayments()
        {
            try
            {
                var paymentData = await (from p in _context.Payments
                                   select new PaymentViewModel()
                                   {
                                       PaymentID = p.PaymentID,
                                       CustomerID = p.CustID,
                                       CustomerName = p.Customer.FirstName + " " + p.Customer.LastName,
                                       PaymentAmount = p.PaymentAmount,
                                       PaymentDescription = p.PaymentMethod.PaymentDescription,
                                       ReservationID = p.ResID,
                                       PaymentDetails = p.PaymentDetails
                                   }).ToAsyncEnumerable().ToList();

                return paymentData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<PaymentViewModel> GetSinglePaymentRecord(string paymentId)
        {
            try
            {
                var paymentRecord = await _context.Payments.FindAsync(paymentId);

                if (paymentRecord != null)
                {
                    return new PaymentViewModel()
                    {
                        PaymentID = paymentRecord.PaymentID,
                        CustomerID = paymentRecord.CustID,
                        CustomerName = paymentRecord.Customer.FirstName + paymentRecord.Customer.LastName,
                        PaymentAmount = paymentRecord.PaymentAmount,
                        PaymentDescription = paymentRecord.PaymentMethod.PaymentDescription,
                        ReservationID = paymentRecord.ResID,
                        PaymentDetails = paymentRecord.PaymentDetails
                    };
                }

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> AddPayment(PaymentViewModel model)
        {
            try
            {
          
                Payment newPaymentRecord = new Payment()
                {
                    PaymentID = Guid.NewGuid().ToString(),
                    CustID = model.CustomerID,
                    ResID = model.ReservationID,
                    PaymentAmount = model.PaymentAmount,
                    PaymentDetails = $"{model.CardHolder},{model.Cardnumber},{model.ExpiryDate},{model.SecurityCode}",
                    PaymentMethodID = model.PaymentMethodID,
                    PaymentDate = DateTime.Now
                };


                await _context.Payments.AddAsync(newPaymentRecord);

                var reservedRoom = await _context.Reservations.FindAsync(model.ReservationID);

                if (reservedRoom != null)
                {
                    reservedRoom.Room.Reserved = true;
                }

                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> UpdatePaymentRecord(string paymentId, PaymentViewModel model)
        {
            try
            {

                if (paymentId != null)
                {

                    Payment paymentRecord = await _context.Payments.FindAsync(paymentId);

                    if (paymentRecord != null)
                    {
                        paymentRecord.PaymentAmount = model.PaymentAmount;
                        //paymentRecord.PaymentDetails = model.PaymentDetails;
                        //paymentRecord.PaymentMethodID = model.PaymentMethodID;

                        return _context.SaveChanges() > 0;
                    }

                    return false;

                }

                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> DeletePayment(string paymentId)
        {
            try
            {
                Payment paymentRecord = await _context.Payments.FindAsync(paymentId);

                if (paymentRecord != null)
                {
                    _context.Payments.Remove(paymentRecord);

                    return _context.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<PaymentMethodViewModel>> GetPaymentMethods()
        {
            try
            {
                var paymentMethods = await (from p in _context.PaymentMethods.AsQueryable()
                                      select new PaymentMethodViewModel()
                                      {
                                          PaymentMethodID = p.PaymentMethodID,
                                          PaymentDescription = p.PaymentDescription
                                      }).ToAsyncEnumerable().ToList();

                return paymentMethods;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
