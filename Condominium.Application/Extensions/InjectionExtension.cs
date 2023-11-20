using Condominium.Application.Interfaces;
using Condominium.Application.Services;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Condominium.Application.Extensions
{
	public static class InjectionExtension
	{
		public static IServiceCollection AddInjectionApplication(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton(configuration);

			services.AddFluentValidation(options =>
				options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies().Where(x => !x.IsDynamic))
			);

			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			services.AddScoped<ICommonAreaApplication, CommonAreaApplication>();

			return services;
		}
	}
}
