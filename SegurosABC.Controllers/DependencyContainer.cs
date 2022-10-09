namespace SegurosABC.Controllers
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddControllers(this IServiceCollection services)
		{
			services.AddScoped<IHistorialPagoController, HistorialPagoController>();
			return services;
		}
	}
}
