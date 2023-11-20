using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class CommonAreaConfiguration : IEntityTypeConfiguration<CommonArea>
	{
		public void Configure(EntityTypeBuilder<CommonArea> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Common_A__3214EC07C940D487");

			builder.ToTable("Common_Area");

			builder.Property(e => e.Name)
				.HasMaxLength(32)
				.IsUnicode(false);
			builder.Property(e => e.Picture).IsUnicode(false);
		}
	}
}
