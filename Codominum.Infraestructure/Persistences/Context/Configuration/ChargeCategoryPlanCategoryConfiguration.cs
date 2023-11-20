using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class ChargeCategoryPlanCategoryConfiguration : IEntityTypeConfiguration<ChargeCategoryPlanCategory>
	{
		public void Configure(EntityTypeBuilder<ChargeCategoryPlanCategory> builder)
		{
			builder
				.HasNoKey()
				.ToTable("Charge_Category_Plan_Category");

			builder.HasOne(d => d.ChargeCategory).WithMany()
				.HasForeignKey(d => d.ChargeCategoryId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_ChageCaregoryPlanCategory_ChageCategory");

			builder.HasOne(d => d.PlanCategory).WithMany()
				.HasForeignKey(d => d.PlanCategoryId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_ChageCaregoryPlanCategory_PlanCategory");
		}
	}
}
