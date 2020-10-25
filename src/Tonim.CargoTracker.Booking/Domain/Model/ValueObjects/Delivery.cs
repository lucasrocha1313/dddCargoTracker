using Tonim.CargoTracker.Booking.Domain.Model.Entities;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class Delivery
    {
        public RoutingStatus RoutingStatus { get; private set; }
        public TransportStatus TransportStatus { get; private set; }
        public Location LastKnownLocation { get; private set; }

        public Voyage CurrentVoyage { get; private set; }
        public LastCargoHandledEvent LastEvent { get; private set; }
        public CargoHandlingActivity NextExpectedActivity { get; private set; }

        public Delivery(LastCargoHandledEvent lastEvent, CargoItinerary itinerary,
                    RouteSpecification routeSpecification)
        {
            LastEvent = lastEvent;

            RoutingStatus = CalculateRoutingStatus(itinerary,
                routeSpecification);
            TransportStatus = CalculateTransportStatus();
            LastKnownLocation = CalculateLastKnownLocation();
            CurrentVoyage = CalculateCurrentVoyage();
        }

        public Delivery UpdateOnRouting(RouteSpecification routeSpecification, CargoItinerary itinerary)
        {
            return new Delivery(LastEvent, itinerary, routeSpecification);
        }

        public static Delivery DerivedFrom(RouteSpecification routeSpecification,
                            CargoItinerary itinerary, LastCargoHandledEvent lastCargoHandledEvent)
        {
            return new Delivery(lastCargoHandledEvent, itinerary, routeSpecification);
        }

        private RoutingStatus CalculateRoutingStatus(CargoItinerary itinerary, RouteSpecification routeSpecification)
        {
            if (itinerary == null || itinerary == CargoItinerary.EMPTY_ITINERARY)
            {
                return RoutingStatus.NOT_ROUTED;
            }
            else
            {
                return RoutingStatus.ROUTED;
            }
        }

        private TransportStatus CalculateTransportStatus()
        {
            if (LastEvent.HandlingEventType == null)
            {
                return TransportStatus.NOT_RECEIVED;
            }

            switch (LastEvent.HandlingEventType)
            {
                case "LOAD":
                    return TransportStatus.ONBOARD_CARRIER;
                case "UNLOAD":
                case "RECEIVE":
                case "CUSTOMS":
                    return TransportStatus.IN_PORT;
                case "CLAIM":
                    return TransportStatus.CLAIMED;
                default:
                    return TransportStatus.UNKNOWN;
            }
        }

        private Location CalculateLastKnownLocation()
        {
            if (LastEvent != null)
            {
                return new Location(LastEvent.HandlingEventLocation);
            }
            else
            {
                return null;
            }
        }

        private Voyage CalculateCurrentVoyage()
        {
            if (TransportStatus == TransportStatus.ONBOARD_CARRIER && LastEvent != null)
            {
                return new Voyage(LastEvent.HandlingEventVoyage);
            }
            else
            {
                return null;
            }
        }
    }
}