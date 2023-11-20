using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class BookingConfiguration : IEntityTypeConfiguration<Booking>
	{
		public void Configure(EntityTypeBuilder<Booking> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Booking__3214EC0709E969A2");

			builder.ToTable("Booking");

			builder.HasOne(d => d.StatusBooking).WithMany(p => p.Bookings)
				.HasForeignKey(d => d.StatusBookingId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Booking_StatusBooking");

			builder.HasOne(d => d.User).WithMany(p => p.Bookings)
				.HasForeignKey(d => d.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Booking_User");
		}
	}
}
