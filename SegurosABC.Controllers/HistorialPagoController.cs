namespace SegurosABC.Controllers
{
	public class HistorialPagoController : IHistorialPagoController
	{
		private readonly IHistorialPagoInputPort _historialPagoInputPort;
		private readonly IHistorialPagoPresenter _historialPagoPresenter;

		public HistorialPagoController(
			IHistorialPagoInputPort historialPagoInputPort,
			IHistorialPagoPresenter historialPagoPresenter)
		{
			_historialPagoInputPort = historialPagoInputPort;
			_historialPagoPresenter = historialPagoPresenter;
		}

		public async Task<IEnumerable<HistoriaPagoDTO>> ObtenerHistorialDePagosAsync(string cedula)
		{
			await _historialPagoInputPort.Handle(cedula);
			return _historialPagoPresenter.Content;
		}
	}
}
