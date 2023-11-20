using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class ChargeCategoryConfiguration : IEntityTypeConfiguration<ChargeCategory>
	{
		public void Configure(EntityTypeBuilder<ChargeCategory> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Charge_C__3214EC070A3576F0");

			builder.ToTable("Charge_Category");

			builder.Property(e => e.Amount).HasColumnType("decimal(16, 2)");
			builder.Property(e => e.Description)
				.HasMaxLength(32)
				.IsUnicode(false);
		}
	}
}
