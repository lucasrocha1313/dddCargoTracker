using System.ComponentModel.DataAnnotations.Schema;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class BookingAmount
    {
        [Column("booking_amount")]
        public int Amount { get; private set; }

        public BookingAmount(int amount) 
        {
            Amount = amount;
        }
    }
}