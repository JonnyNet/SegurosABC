using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SegurosABC.Controllers;
using SegurosABC.Presenters;
using SegurosABC.Repositories;
using SegurosABC.UseCases;

namespace SegurosABC.IoC
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddSegurosABCDependencies(
			this IServiceCollection services,
			IConfiguration configuration,
			string connectionString)
		{
			services.AddRepositories(configuration, connectionString);
			services.AddUsesCases();
			services.AddPresenters();
			services.AddControllers();
			return services;
		}

		public static IApplicationBuilder RunMigrations(this IApplicationBuilder app)
		{
			app.RunMigrationsRepositories();
			return app;
		}
	}
}
