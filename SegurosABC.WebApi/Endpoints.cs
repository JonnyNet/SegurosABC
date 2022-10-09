namespace SegurosABC.WebApi
{
	public static class Endpoints
	{
		public static WebApplication UseSegurosABCEndpoints(this WebApplication app)
		{
			app.MapGet("/api/historal-pagos",
				async (string? cedula, IHistorialPagoController controller) =>
				Results.Ok(await controller.ObtenerHistorialDePagosAsync(cedula)));

			return app;
		}
	}
}
