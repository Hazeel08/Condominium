using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class StatusIncidenceConfiguration : IEntityTypeConfiguration<StatusIncidence>
	{
		public void Configure(EntityTypeBuilder<StatusIncidence> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Status_I__3214EC074AB69984");

			builder.ToTable("Status_Incidence");

			builder.Property(e => e.Description)
				.HasMaxLength(16)
				.IsUnicode(false);
		}
	}
}
