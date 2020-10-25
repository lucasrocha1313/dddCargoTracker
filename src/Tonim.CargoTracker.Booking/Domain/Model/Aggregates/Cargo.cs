using Tonim.CargoTracker.Booking.Domain.Model.ValueObjects;
using Tonim.CargoTracker.Routing.Domain.Models.ValueObjects;

namespace Tonim.CargoTracker.Booking.Domain.Model.Aggregates
{
    public class Cargo
    {
        public long Id { get; set; }
        public BookingId BookingId { get; set; }
        public BookingAmount BookingAmount { get; set; }
        public Location Origin { get; set; }        
    }
}