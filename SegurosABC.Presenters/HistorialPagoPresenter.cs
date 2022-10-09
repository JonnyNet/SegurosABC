namespace SegurosABC.Presenters
{
	public class HistorialPagoPresenter : IHistorialPagoPresenter, IHistorialPagoOutputPort
	{
		public IEnumerable<HistoriaPagoDTO> Content { get; private set; }

		public Task Handle(IEnumerable<HistoriaPagoDTO> obj)
		{
			Content = obj;
			return Task.CompletedTask;
		}
	}
}
