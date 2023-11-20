using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class CommonAreaBookingConfiguration : IEntityTypeConfiguration<CommonAreaBooking>
	{
		public void Configure(EntityTypeBuilder<CommonAreaBooking> builder)
		{
			builder
				.HasNoKey()
				.ToTable("Common_Area_Booking");

			builder.HasOne(d => d.Booking).WithMany()
				.HasForeignKey(d => d.BookingId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_CommonAreaBooking_Booking");

			builder.HasOne(d => d.CommonArea).WithMany()
				.HasForeignKey(d => d.CommonAreaId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_CommonAreaBooking_CommonArea");
		}
	}
}
