using SegurosABC.Repositories.Repositories;

namespace SegurosABC.Repositories
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddRepositories(
			this IServiceCollection services,
			IConfiguration configuration,
			string connectionString)
		{
			services.AddDbContext<SegurosABCContextFactory>();
			services.AddDbContext<SegurosABCContext>(options
				=> options.UseSqlServer(configuration.GetConnectionString(connectionString)));

			services.AddScoped<IDbContext>(provider => provider.GetService<SegurosABCContext>());
			services.AddScoped<IHistorialPagoRespository, HistorialPagoRespository>();

			return services;
		}

		public static IApplicationBuilder RunMigrationsRepositories(this IApplicationBuilder app)
		{
			using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetRequiredService<SegurosABCContextFactory>();
				context.Database.Migrate();
			}
			return app;
		}
	}
}
