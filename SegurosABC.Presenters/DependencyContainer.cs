namespace SegurosABC.Presenters
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddPresenters(this IServiceCollection services)
		{
			services.AddScoped<HistorialPagoPresenter>();

			services.AddScoped<IHistorialPagoPresenter>(x => x.GetService<HistorialPagoPresenter>());
			services.AddScoped<IHistorialPagoOutputPort>(x => x.GetService<HistorialPagoPresenter>());
			return services;
		}
	}
}
