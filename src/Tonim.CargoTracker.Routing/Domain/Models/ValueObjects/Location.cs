namespace Tonim.CargoTracker.Routing.Domain.Models.ValueObjects
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