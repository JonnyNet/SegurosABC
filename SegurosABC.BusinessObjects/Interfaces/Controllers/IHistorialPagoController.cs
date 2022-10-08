namespace SegurosABC.BusinessObjects.Interfaces.Controllers
{
	public interface IHistorialPagoController
	{
		Task<IEnumerable<HistoriaPagoDTO>> ObtenerHistorialDePagosAsync(int? cedula);
	}
}
