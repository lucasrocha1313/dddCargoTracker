using System.ComponentModel.DataAnnotations.Schema;

namespace Tonim.CargoTracker.Booking.Domain.Model.Entities
{
    public class Location
    {
        public string UniqueCode { get; private set; }
        public Location(string code)
        {
            UniqueCode = code;
        }
    }
}