using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class StatusDebtConfiguration : IEntityTypeConfiguration<StatusDebt>
	{
		public void Configure(EntityTypeBuilder<StatusDebt> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Status_D__3214EC07CFCB9717");

			builder.ToTable("Status_Debt");

			builder.Property(e => e.Description)
				.HasMaxLength(16)
				.IsUnicode(false);
		}
	}
}
