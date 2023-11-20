using Condominium.Domain.Entities;

namespace Codominum.Infraestructure.Persistences.Interfaces
{
	public interface ICommonAreaRepository
	{
		Task<IEnumerable<CommonArea>> ListCommonAreas();
		Task<CommonArea> CommonAreaById(int id);
		Task<bool> RegisterCommonArea(CommonArea commonArea);
		Task<bool> UpdateCommonArea(CommonArea commonArea);
	}
}
