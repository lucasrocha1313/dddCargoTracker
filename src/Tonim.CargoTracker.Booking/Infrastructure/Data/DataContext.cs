using Microsoft.EntityFrameworkCore;
using Tonim.CargoTracker.Booking.Domain.Model.Aggregates;

namespace Tonim.CargoTracker.Booking.Infrastructure.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cargo> Cargo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>(e => {
                e.ToTable("cargo");
                e.OwnsOne(o => o.BookingId).Property(p => p.Id).HasField("booking_id");
                e.OwnsOne(o => o.BookingAmount).Property(p => p.Amount).HasField("booking_amount");
                e.OwnsOne(o => o.Origin).Property(p => p.UniqueCode).HasField("origin_id");
                e.OwnsOne(o => o.RouteSpecification).Property(p => p.Origin).HasField("spec_origin_id");
                e.OwnsOne(o => o.RouteSpecification).Property(p => p.Destination).HasField("spec_destination_id");
                e.OwnsOne(o => o.RouteSpecification).Property(p => p.ArrivalDeadline).HasField("spec_arrival_deadline");
                e.OwnsOne(o => o.Itinerary).OwnsMany(o => o.Legs);
                e.OwnsOne(o => o.Delivery).Property(p => p.RoutingStatus).HasField("routing_status");
                e.OwnsOne(o => o.Delivery).Property(p => p.TransportStatus).HasField("transport_status");
                e.OwnsOne(o => o.Delivery).Property(p => p.LastKnownLocation).HasField("last_known_location_id");
                e.OwnsOne(o => o.Delivery).Property(p => p.CurrentVoyage).HasField("current_voyage_number");
            });
        }
    }
}