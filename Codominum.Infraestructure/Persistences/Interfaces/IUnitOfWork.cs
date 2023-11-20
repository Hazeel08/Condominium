namespace Codominum.Infraestructure.Persistences.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		ICommonAreaRepository CommonArea { get; }
		void SaveChanges();
		Task SaveChangesAsync();
	}
}
