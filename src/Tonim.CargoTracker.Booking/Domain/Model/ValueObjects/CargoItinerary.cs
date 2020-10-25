using System.Collections.Generic;
using System.Linq;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class CargoItinerary
    {
        public IEnumerable<Leg> Legs { get; private set; } = Enumerable.Empty<Leg>();
        public static CargoItinerary EMPTY_ITINERARY { get; internal set; } = new CargoItinerary();

        public CargoItinerary(IEnumerable<Leg> legs)
        {
            Legs = legs;
        }

        public CargoItinerary(){}
    }
}