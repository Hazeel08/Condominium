using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
	{
		public void Configure(EntityTypeBuilder<Schedule> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Schedule__3214EC07F0F4C251");

			builder.ToTable("Schedule");

			builder.Property(e => e.Date).HasColumnType("datetime");
			builder.Property(e => e.EndTime)
				.HasMaxLength(16)
				.IsUnicode(false);
			builder.Property(e => e.StartTime)
				.HasMaxLength(16)
				.IsUnicode(false);
		}
	}
}
