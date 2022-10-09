using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SegurosABC.Repositories.DataContext
{
	public class SegurosABCContext : DbContext, IDbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Pago> Pagos { get; set; }

		public SegurosABCContext(DbContextOptions<SegurosABCContext> options) : base(options)
		{
		}

		public DbConnection GetConnection()
		{
			return Database.GetDbConnection();
		}

		public DatabaseFacade GetDatabase()
		{
			return Database;
		}
	}
}
