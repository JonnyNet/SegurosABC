namespace SegurosABC.Entities.Interfaces.Repositories
{
	public interface IHistorialPagoRespository
	{
		Task<IEnumerable<HistoriaPago>> ObtenerHistorialDePagosAsync(int? cedula);
	}
}
