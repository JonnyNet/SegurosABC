using System.ComponentModel.DataAnnotations;

namespace SegurosABC.Entities.Entities
{
	public class Cliente
	{
		public string Nombre { get; set; }
		[Key]
		public string Cedula { get; set; }
		public int PIN { get; set; }
	}
}
