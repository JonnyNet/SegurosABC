namespace SegurosABC.Entities.Interfaces
{
	public interface IPresenter<T>
	{
		public T Content { get; }
	}
}
