namespace SegurosABC.UseCases
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddUsesCases(this IServiceCollection services)
		{
			services.AddTransient<IHistorialPagoInputPort, HistorialPagosInteractor>();
			return services;
		}
	}
}
