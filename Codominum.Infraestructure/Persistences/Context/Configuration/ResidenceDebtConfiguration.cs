using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class ResidenceDebtConfiguration : IEntityTypeConfiguration<ResidenceDebt>
	{
		public void Configure(EntityTypeBuilder<ResidenceDebt> builder)
		{
			builder
				.HasNoKey()
				.ToTable("Residence_Debt");

			builder.HasOne(d => d.Debt).WithMany()
				.HasForeignKey(d => d.DebtId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_ResidenceDebt_Debt");

			builder.HasOne(d => d.Residence).WithMany()
				.HasForeignKey(d => d.ResidenceId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_ResidenceDebt_Residence");
		}
	}
}
