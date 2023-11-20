using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codominum.Infraestructure.Persistences.Context.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(e => e.Id).HasName("PK__User__3214EC0785BC8A75");

			builder.ToTable("User");

			builder.Property(e => e.Email)
				.HasMaxLength(32)
				.IsUnicode(false);
			builder.Property(e => e.FirstLastName)
				.HasMaxLength(32)
				.IsUnicode(false);
			builder.Property(e => e.Name)
				.HasMaxLength(32)
				.IsUnicode(false);
			builder.Property(e => e.Password)
				.HasMaxLength(16)
				.IsUnicode(false);
			builder.Property(e => e.SecondLastName)
				.HasMaxLength(32)
				.IsUnicode(false);

			builder.HasOne(d => d.Role).WithMany(p => p.Users)
				.HasForeignKey(d => d.RoleId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_User_Role");

			builder.HasOne(d => d.Status).WithMany(p => p.Users)
				.HasForeignKey(d => d.StatusId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_User_Status");
		}
	}
}
