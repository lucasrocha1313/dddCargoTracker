using System;
using Tonim.CargoTracker.Routing.Domain.Models.ValueObjects;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class RouteSpecification
    {
        public Location Origin { get; private set; }
        public Location Destination { get; private set; }

        public DateTime ArrivalDeadline { get; private set; }

        public RouteSpecification(Location origin, Location destination, DateTime arrivalDeadline)
        {
            Origin = origin;
            Destination = destination;
            ArrivalDeadline = arrivalDeadline;
        }
    }
}