using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class InformationTypeConfiguration : IEntityTypeConfiguration<InformationType>
	{
		public void Configure(EntityTypeBuilder<InformationType> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Informat__3214EC07589F2433");

			builder.ToTable("Information_Type");

			builder.Property(e => e.Description)
				.HasMaxLength(32)
				.IsUnicode(false);
		}
	}
}
