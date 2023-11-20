using Condominium.Infraestructure.Persistences.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Codominum.Infraestructure.Extensions
{
	public static class InjectionExtensions
	{
		public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
		{
			var assembly = typeof(CondominiumContext).Assembly.FullName;

			services.AddDbContext<CondominiumContext>(options =>
				options.UseSqlServer(
						configuration.GetConnectionString("DefaultConnection"), 
						b => b.MigrationsAssembly(assembly)
				), ServiceLifetime.Transient
			);

			return services;
		}
	}
}
