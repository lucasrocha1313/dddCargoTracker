using Tonim.CargoTracker.Booking.Domain.Model.Commands;
using Tonim.CargoTracker.Booking.Domain.Model.Entities;
using Tonim.CargoTracker.Booking.Domain.Model.ValueObjects;

namespace Tonim.CargoTracker.Booking.Domain.Model.Aggregates
{
    public class Cargo
    {
        public long Id { get; private set; }
        public BookingId BookingId { get; private set; }
        public BookingAmount BookingAmount { get; private set; }
        public Location Origin { get; private set; }
        public RouteSpecification RouteSpecification { get; private set; }
        public CargoItinerary Itinerary { get; private set; } 
        public Delivery Delivery { get; private set; }

        public Cargo(BookCargoCommand bookCargoCommand)
        {
            BookingId = new BookingId(bookCargoCommand.BookingId);
            RouteSpecification = new RouteSpecification(
                new Location(bookCargoCommand.OriginLocation),
                new Location(bookCargoCommand.DestLocation),
                bookCargoCommand.DestArrivalDeadline
            );
            Origin = RouteSpecification.Origin;
            BookingAmount = new BookingAmount(bookCargoCommand.BookingAmount);
            //TODO finalizar o construtor
            //TODO tentar fazer o EF funcionar
        }  
    }
}