namespace SegurosABC.Repositories.DataContext
{
	public class SegurosABCContextFactory : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Pago> Pagos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SegurosABC");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
