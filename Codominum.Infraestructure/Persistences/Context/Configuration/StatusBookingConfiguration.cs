using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class StatusBookingConfiguration : IEntityTypeConfiguration<StatusBooking>
	{
		public void Configure(EntityTypeBuilder<StatusBooking> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Status_B__3214EC071D9BF085");

			builder.ToTable("Status_Booking");

			builder.Property(e => e.Description)
				.HasMaxLength(16)
				.IsUnicode(false);
		}
	}
}
