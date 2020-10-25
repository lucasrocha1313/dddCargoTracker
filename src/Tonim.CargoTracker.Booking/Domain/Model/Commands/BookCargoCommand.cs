using System;

namespace Tonim.CargoTracker.Booking.Domain.Model.Commands
{
    public class BookCargoCommand
    {
        public string BookingId { get; private set; }
        public int BookingAmount { get; private set; }
        public string OriginLocation { get; private set; }
        public string DestLocation { get; private set; }
        public DateTime DestArrivalDeadline { get; private set; }

        public BookCargoCommand(string bookingId, int bookingAmount, string originLocation,
            string destLocation, DateTime destArrivalDeadline)
        {
            BookingId = bookingId;
            BookingAmount = bookingAmount;
            OriginLocation = originLocation;
            DestLocation = destLocation;
            DestArrivalDeadline = destArrivalDeadline;
        }
    }
}