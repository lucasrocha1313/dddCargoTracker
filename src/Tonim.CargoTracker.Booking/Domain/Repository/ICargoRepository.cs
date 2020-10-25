using System.Collections.Generic;
using Tonim.CargoTracker.Booking.Domain.Model.Aggregates;

namespace Tonim.CargoTracker.Booking.Domain.Repository
{
    public interface ICargoRepository
    {
         List<Cargo> FindAll();
         Cargo FindByBookingId(BookingId bookingId);
         List<BookingId> GetAllBookingIds();
    }
}