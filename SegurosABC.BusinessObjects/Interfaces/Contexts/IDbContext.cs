using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SegurosABC.BusinessObjects.Interfaces.Contexts
{
	public interface IDbContext
	{
		DbSet<Cliente> Clientes { get; set; }
		DbSet<Pago> Pagos { get; set; }

		DbConnection GetConnection();
		DatabaseFacade GetDatabase();
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}
