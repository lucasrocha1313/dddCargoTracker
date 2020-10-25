namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class BookingAmount
    {
        public int Amount { get; private set; }

        public BookingAmount(int amount) 
        {
            Amount = amount;
        }
    }
}