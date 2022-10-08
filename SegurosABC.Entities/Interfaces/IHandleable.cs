namespace SegurosABC.Entities.Interfaces
{
	public interface IHandleable<T>
	{
		Task Handle(T obj);
	}
}
