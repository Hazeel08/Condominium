using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class PlanCategoryConfiguration : IEntityTypeConfiguration<PlanCategory>
	{
		public void Configure(EntityTypeBuilder<PlanCategory> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Plan_Cat__3214EC073D73FDD0");

			builder.ToTable("Plan_Category");

			builder.Property(e => e.Amount).HasColumnType("decimal(16, 2)");
			builder.Property(e => e.Description)
				.HasMaxLength(32)
				.IsUnicode(false);
		}
	}
}
