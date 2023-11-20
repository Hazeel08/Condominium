using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class IncidenceConfiguration : IEntityTypeConfiguration<Incidence>
	{
		public void Configure(EntityTypeBuilder<Incidence> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Incidenc__3214EC0751C5448A");

			builder.ToTable("Incidence");

			builder.Property(e => e.Description)
				.HasMaxLength(512)
				.IsUnicode(false);

			builder.HasOne(d => d.StatusIncidence).WithMany(p => p.Incidences)
				.HasForeignKey(d => d.StatusIncidenceId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Incidence_Status_Incidence");

			builder.HasOne(d => d.User).WithMany(p => p.Incidences)
				.HasForeignKey(d => d.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Incidence_User");
		}
	}
}
