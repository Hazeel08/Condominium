using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class ResidenceConfiguration : IEntityTypeConfiguration<Residence>
	{
		public void Configure(EntityTypeBuilder<Residence> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Residenc__3214EC07095CE93A");

			builder.ToTable("Residence");

			builder.Property(e => e.Picture).IsUnicode(false);
			builder.Property(e => e.Price).HasColumnType("decimal(16, 2)");
			builder.Property(e => e.ResidenceNumber)
				.HasMaxLength(8)
				.IsUnicode(false);
			builder.Property(e => e.StartYear)
				.HasMaxLength(16)
				.IsUnicode(false);

			builder.HasOne(d => d.StatusResidence).WithMany(p => p.Residences)
				.HasForeignKey(d => d.StatusResidenceId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Residence_StatusResidence");

			builder.HasOne(d => d.User).WithMany(p => p.Residences)
				.HasForeignKey(d => d.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Residence_User");
		}
	}
}
