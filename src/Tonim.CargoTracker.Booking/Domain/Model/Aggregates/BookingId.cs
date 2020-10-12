namespace Tonim.CargoTracker.Booking.Domain.Model.Aggregates
{
    public class BookingId
    {
        public string Id { get; private set; }

        public BookingId(string IdBooking)
        {
            Id = IdBooking;
        }
    }
}