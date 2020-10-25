using System.ComponentModel.DataAnnotations.Schema;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class Voyage
    {
        public string VoyageNumber { get; private set; }

        public Voyage(string voyageNumber)
        {
            VoyageNumber = voyageNumber;
        }
    }
}