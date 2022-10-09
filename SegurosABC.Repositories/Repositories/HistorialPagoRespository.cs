namespace SegurosABC.Repositories.Repositories
{
	public class HistorialPagoRespository : IHistorialPagoRespository
	{
		private readonly IDbContext _dbContext;
		private const string _SP_CONSULTA_PAGOS_CLIENTE = "ConsultaPagosCliente";
		private const string _CEDULA_PARAMETER = "@cedula";

		public HistorialPagoRespository(IDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IEnumerable<HistoriaPago>> ObtenerHistorialDePagosAsync(string cedula)
		{
			using (DbCommand command = _dbContext.GetConnection().CreateCommand())
			{
				command.CommandText = _SP_CONSULTA_PAGOS_CLIENTE;
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter(_CEDULA_PARAMETER, cedula));

				_dbContext.GetDatabase().OpenConnection();

				DbDataReader reader = await command.ExecuteReaderAsync();
				var pagos = reader.Select(item => new HistoriaPago
				{
					Cedula = item.GetValue<string>("cedula"),
					Nombre = item.GetValue<string>("nombre"),
					Monto = item.GetValue<decimal>("monto"),
					FechaPago = item.GetValue<DateTime>("fechapago")
				});
				return pagos;
			}
		}
	}
}
