using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class InformationConfiguration : IEntityTypeConfiguration<Information>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Information> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Informat__3214EC07D202285F");

			builder.Property(e => e.Date).HasColumnType("datetime");
			builder.Property(e => e.Description)
				.HasMaxLength(1024)
				.IsUnicode(false);
			builder.Property(e => e.Picture).IsUnicode(false);
			builder.Property(e => e.Subject)
				.HasMaxLength(32)
				.IsUnicode(false);

			builder.HasOne(d => d.InformationType).WithMany(p => p.Information)
				.HasForeignKey(d => d.InformationTypeId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Information_InformationType");

			builder.HasOne(d => d.User).WithMany(p => p.Information)
				.HasForeignKey(d => d.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Information_User");
		}
	}
}
