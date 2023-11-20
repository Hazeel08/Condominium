using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class DebtConfiguration : IEntityTypeConfiguration<Debt>
	{
		public void Configure(EntityTypeBuilder<Debt> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Debt__3214EC07C4EA18E8");

			builder.ToTable("Debt");

			builder.Property(e => e.Amount).HasColumnType("decimal(16, 2)");
			builder.Property(e => e.Date).HasColumnType("datetime");

			builder.HasOne(d => d.PlanCategory).WithMany(p => p.Debts)
				.HasForeignKey(d => d.PlanCategoryId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Debt_PlanCategory");

			builder.HasOne(d => d.StatusDebt).WithMany(p => p.Debts)
				.HasForeignKey(d => d.StatusDebtId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Debt_StatusDebt");
		}
	}
}
