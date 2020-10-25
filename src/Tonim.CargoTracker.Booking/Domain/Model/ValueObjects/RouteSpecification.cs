using System;
using System.ComponentModel.DataAnnotations.Schema;
using Tonim.CargoTracker.Booking.Domain.Model.Entities;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class RouteSpecification
    {
        [Column("spec_origin_id")]
        public Location Origin { get; private set; }
        [Column("spec_destination_id")]
        public Location Destination { get; private set; }        
        [Column("spec_arrival_deadline")]
        public DateTime ArrivalDeadline { get; private set; }

        public RouteSpecification(Location origin, Location destination, DateTime arrivalDeadline)
        {
            Origin = origin;
            Destination = destination;
            ArrivalDeadline = arrivalDeadline;
        }
    }
}