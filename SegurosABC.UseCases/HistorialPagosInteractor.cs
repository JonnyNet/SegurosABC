namespace SegurosABC.UseCases
{
	public class HistorialPagosInteractor : IHistorialPagoInputPort
	{
		private readonly IHistorialPagoOutputPort _historialPagoOutputPort;
		private readonly IHistorialPagoRespository _historialPagoRepository;

		public async Task Handle(int? cedula)
		{
			IEnumerable<HistoriaPago> historialPagos = await _historialPagoRepository.ObtenerHistorialDePagosAsync(cedula);
			var resultadoHistorialPagos = historialPagos.Select(x => (HistoriaPagoDTO)x);
			await _historialPagoOutputPort.Handle(resultadoHistorialPagos);
		}
	}
}
