namespace SegurosABC.BusinessObjects.DTOs
{
	public class HistoriaPagoDTO
	{
		public string Cedula { get; set; }
		public string Nombre { get; set; }
		public DateTime FechaPago { get; set; }
		public decimal Monto { get; set; }


		public static explicit operator HistoriaPagoDTO(HistoriaPago historiaPago) => new()
		{
			Nombre = historiaPago.Nombre,
			FechaPago = historiaPago.FechaPago,
			Monto = historiaPago.Monto,
			Cedula = historiaPago.Cedula
		};
	}
}
