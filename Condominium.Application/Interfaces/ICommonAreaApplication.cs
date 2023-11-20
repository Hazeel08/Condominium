using Condominium.Application.Commons.Bases;
using Condominium.Application.Dtos.Request;
using Condominium.Application.Dtos.Response;

namespace Condominium.Application.Interfaces
{
	public interface ICommonAreaApplication
	{
		Task<BaseResponse<CommonAreaResponseDto>> ListCommonAreas();
		Task<BaseResponse<CommonAreaResponseDto>> GetCommonAreaById(int id);
		Task<BaseResponse<bool>> RegisterCommonArea(CommonAreaRequestDto area);
		Task<BaseResponse<bool>> UpdateCommonArea(CommonAreaRequestDto area);
		Task<BaseResponse<bool>> RegisterCommonArea(CommonAreaRequestDto area, int id);
	}
}
