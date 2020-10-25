using System.ComponentModel.DataAnnotations.Schema;

namespace Tonim.CargoTracker.Booking.Domain.Model.Aggregates
{
    public class BookingId
    {
        [Column("booking_id")]
        public string Id { get; private set; }

        public BookingId(string IdBooking)
        {
            Id = IdBooking;
        }
    }
}