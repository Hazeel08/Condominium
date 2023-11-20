using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class StatusResidenceConfiguration : IEntityTypeConfiguration<StatusResidence>
	{
		public void Configure(EntityTypeBuilder<StatusResidence> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Status_R__3214EC07F816D6A5");

			builder.ToTable("Status_Residence");

			builder.Property(e => e.Description)
				.HasMaxLength(16)
				.IsUnicode(false);
		}
	}
}
