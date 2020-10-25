namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class LastCargoHandledEvent
    {
        public int HandlingEventId { get; private set; }
        public string HandlingEventType { get; private set; }
        public string HandlingEnventVoyage { get; }
        public string HandlingEventVoyage { get; private set; }
        public string HandlingEventLocation { get; private set; }

        public LastCargoHandledEvent(int handlingEventId, string handlingEventType,
            string handlingEnventVoyage, string handlingEventLocation)
        {
            HandlingEventId = handlingEventId;
            HandlingEventType = handlingEventType;
            HandlingEnventVoyage = handlingEnventVoyage;
            HandlingEventLocation = handlingEventLocation;
        }
    }
}