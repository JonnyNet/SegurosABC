namespace SegurosABC.Repositories.Configurations
{
	public class PagoConfiguration : IEntityTypeConfiguration<Pago>
	{
		public void Configure(EntityTypeBuilder<Pago> builder)
		{
			builder.Property(x => x.Monto)
				.HasPrecision(11, 2);

			builder.Property(x => x.FechaPago)
				.HasColumnType("datetime");

			builder.Property(x => x.Cedula)
				.HasMaxLength(25);

			builder.HasOne(x => x.Cliente)
				.WithMany()
				.HasForeignKey(x => x.Cedula);

			builder.HasData(
				new Pago
				{
					Id = 1,
					Cedula = "8-75-584",
					FechaPago = new DateTime(2021, 4, 4),
					Monto = 200.00M
				},
				new Pago
				{
					Id = 2,
					Cedula = "8-75-584",
					FechaPago = new DateTime(2021, 1, 5),
					Monto = 198.22M
				}, new Pago
				{
					Id = 3,
					Cedula = "8-75-584",
					FechaPago = new DateTime(2021, 1, 6),
					Monto = 210.00M
				},
				new Pago
				{
					Id = 4,
					Cedula = "PE-254-845",
					FechaPago = new DateTime(2021, 4, 30),
					Monto = 200.00M
				},
				new Pago
				{
					Id = 5,
					Cedula = "PE-254-845",
					FechaPago = new DateTime(2021, 3, 29),
					Monto = 198.22M
				},
				new Pago
				{
					Id = 6,
					Cedula = "PE-254-845",
					FechaPago = new DateTime(2021, 2, 17),
					Monto = 210.00M
				});
		}
	}
}
