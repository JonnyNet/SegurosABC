namespace SegurosABC.BusinessObjects.Interfaces.Contexts
{
	public interface IDbContext
	{
		DbSet<Cliente> Clientes { get; set; }
		DbSet<Pago> Pagos { get; set; }

		DbConnection GetConnection();

		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}
