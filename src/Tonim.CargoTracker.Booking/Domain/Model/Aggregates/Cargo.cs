namespace Tonim.CargoTracker.Booking.Domain.Model.Aggregates
{
    public class Cargo
    {
        public long Id { get; set; }
        public BookingId BookingId { get; set; }
    }
}