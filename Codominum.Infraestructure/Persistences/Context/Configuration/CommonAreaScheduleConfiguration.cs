using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class CommonAreaScheduleConfiguration : IEntityTypeConfiguration<CommonAreaSchedule>
	{
		public void Configure(EntityTypeBuilder<CommonAreaSchedule> builder)
		{
			builder
				.HasNoKey()
				.ToTable("Common_Area_Schedule");

			builder.HasOne(d => d.CommonArea).WithMany()
				.HasForeignKey(d => d.CommonAreaId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_CommonAreaSchedule_CommonArea");

			builder.HasOne(d => d.Schedule).WithMany()
				.HasForeignKey(d => d.ScheduleId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_CommonAreaSchedule_Schedule");
		}
	}
}
