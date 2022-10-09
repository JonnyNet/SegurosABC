namespace SegurosABC.Entities.Entities
{
	public class Pago
	{
		public int Id { get; set; }
		public string Cedula { get; set; }
		public DateTime FechaPago { get; set; }
		public decimal Monto { get; set; }

		public Cliente Cliente { get; set; }
	}
}
