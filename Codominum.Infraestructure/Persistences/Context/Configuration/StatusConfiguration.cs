using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class StatusConfiguration : IEntityTypeConfiguration<Status>
	{
		public void Configure(EntityTypeBuilder<Status> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__Status__3214EC07F6BD1271");

			builder.ToTable("Status");

			builder.Property(e => e.Description)
				.HasMaxLength(16)
				.IsUnicode(false);
		}
	}
}
