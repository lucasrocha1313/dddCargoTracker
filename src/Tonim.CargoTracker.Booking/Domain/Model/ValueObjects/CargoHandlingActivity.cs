using Tonim.CargoTracker.Booking.Domain.Model.Entities;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class CargoHandlingActivity
    {
        public string Type { get; private set; }
        public Location Location { get; private set; }
        public Voyage Voyage { get; private set; }
        private readonly string type;

        public CargoHandlingActivity(string type, Location location)
        {
            this.type = type;
            Location = location;
        }
        private readonly Voyage voyage;

        public CargoHandlingActivity(string type, Location location, Voyage voyage)
        {
            Voyage = voyage;
            Type = type;
            Location = location;
        }
    }
}