namespace SegurosABC.Repositories.Configurations
{
	public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
	{
		public void Configure(EntityTypeBuilder<Cliente> builder)
		{
			builder.HasKey(x => x.Cedula);

			builder.HasIndex(x => x.PIN)
				.IsUnique();

			builder.Property(x => x.Cedula)
				.IsRequired()
				.HasMaxLength(25);

			builder.Property(x => x.Nombre)
				.IsRequired()
				.HasMaxLength(100);

			builder.HasData(
				new Cliente
				{
					Nombre = "Juan Perez",
					Cedula = "8-75-584",
					PIN = 1478
				},
				new Cliente
				{
					Nombre = "Miguel Batista",
					Cedula = "PE-254-845",
					PIN = 1244
				});
		}
	}
}
