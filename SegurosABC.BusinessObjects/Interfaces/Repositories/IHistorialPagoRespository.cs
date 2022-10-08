namespace SegurosABC.BusinessObjects.Interfaces.Repositories
{
	public interface IHistorialPagoRespository
	{
		Task<IEnumerable<HistoriaPago>> ObtenerHistorialDePagosAsync(int? cedula);
	}
}
