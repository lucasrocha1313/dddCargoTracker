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
                e.OwnsOne(o => o.BookingId);
                e.OwnsOne(o => o.BookingAmount);
                e.OwnsOne(o => o.Origin);
                e.OwnsOne(o => o.RouteSpecification);
                e.OwnsOne(o => o.RouteSpecification);
                e.OwnsOne(o => o.RouteSpecification);
                e.OwnsOne(o => o.Itinerary).OwnsMany(o => o.Legs);
                e.OwnsOne(o => o.Delivery);
                e.OwnsOne(o => o.Delivery);
                e.OwnsOne(o => o.Delivery);
                e.OwnsOne(o => o.Delivery);
            });
        }
    }
}