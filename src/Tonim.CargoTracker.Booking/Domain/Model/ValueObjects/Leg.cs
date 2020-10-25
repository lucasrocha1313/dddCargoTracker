using System;
using System.ComponentModel.DataAnnotations.Schema;
using Tonim.CargoTracker.Booking.Domain.Model.Entities;

namespace Tonim.CargoTracker.Booking.Domain.Model.ValueObjects
{
    public class Leg
    {
        public long Id { get; private set; }
        public Voyage Voyage { get; private set; }
        [Column("load_location_id")]
        public Location LoadLocation { get; private set; }
        [Column("unload_location_id")]
        public Location UnloadLocation { get; private set; }
        [Column("load_time")]
        public DateTime LoadTime { get; private set; }
        [Column("unload_time")]
        public DateTime UnloadTime { get; private set; }

        public Leg(Voyage voyage, Location loadLocation, Location unloadLocation,
            DateTime loadTime, DateTime unloadTime)
        {
            Voyage = voyage;
            LoadLocation = loadLocation;
            UnloadLocation = unloadLocation;
            LoadTime = loadTime;
            UnloadTime = unloadTime;
        }

    }
}