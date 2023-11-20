using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class BookingScheduleConfiguration : IEntityTypeConfiguration<BookingSchedule>
	{
		public void Configure(EntityTypeBuilder<BookingSchedule> builder)
		{
			builder
				.HasNoKey()
				.ToTable("Booking_Schedule");

			builder.HasOne(d => d.Booking).WithMany()
				.HasForeignKey(d => d.BookingId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_BookingSchedule_Booking");

			builder.HasOne(d => d.Schedule).WithMany()
				.HasForeignKey(d => d.ScheduleId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_BookingScheduke_Schedule");
		}
	}
}
