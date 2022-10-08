namespace SegurosABC.BusinessObjects.DTOs
{
	public class HistoriaPagoDTO
	{
		public int Cedula { get; set; }
		public string Nombre { get; set; }
		public DateTime FechaPago { get; set; }
		public decimal Monto { get; set; }
	}
}
