namespace SegurosABC.UseCases
{
	public class HistorialPagosInteractor : IHistorialPagoInputPort
	{
		private readonly IHistorialPagoOutputPort _historialPagoOutputPort;
		private readonly IHistorialPagoRespository _historialPagoRepository;

		public HistorialPagosInteractor(
			IHistorialPagoOutputPort historialPagoOutputPort,
			IHistorialPagoRespository historialPagoRepository)
		{
			_historialPagoOutputPort = historialPagoOutputPort;
			_historialPagoRepository = historialPagoRepository;
		}

		public async Task Handle(string cedula)
		{
			IEnumerable<HistoriaPago> historialPagos = await _historialPagoRepository.ObtenerHistorialDePagosAsync(cedula);
			var resultadoHistorialPagos = historialPagos.Select(x => (HistoriaPagoDTO)x);
			await _historialPagoOutputPort.Handle(resultadoHistorialPagos);
		}
	}
}
