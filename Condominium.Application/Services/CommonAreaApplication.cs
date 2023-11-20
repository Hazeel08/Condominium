using AutoMapper;
using Codominum.Infraestructure.Persistences.Interfaces;
using Condominium.Application.Commons.Bases;
using Condominium.Application.Dtos.Request;
using Condominium.Application.Dtos.Response;
using Condominium.Application.Interfaces;
using Condominium.Application.Validator.CommonArea;
using Condominium.Domain.Entities;

namespace Condominium.Application.Services
{
	public class CommonAreaApplication : ICommonAreaApplication
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly CommonAreaValidator _validationRules;

		public CommonAreaApplication(IUnitOfWork unitOfWork, IMapper mapper, CommonAreaValidator validationRules)
		{
			this._unitOfWork = unitOfWork;
			this._mapper = mapper;
			this._validationRules = validationRules;
		}
		public async Task<BaseResponse<CommonAreaResponseDto>> ListCommonAreas()
		{
			try
			{
				var response = new BaseResponse<CommonAreaResponseDto>();
				var commonAreas = await _unitOfWork.CommonArea.ListCommonAreas();

				if (commonAreas is not null)
				{
					response.IsSuccess = true;
					response.Data = _mapper.Map<CommonAreaResponseDto>(commonAreas);
					response.Message = "Consulta exitosa";
				}
				else
				{
					response.IsSuccess = false;
					response.Message = "No se encontraron registros";
				}
				return response;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al obtener las areas comunes {ex.Message}");
			}
		}

		public async Task<BaseResponse<CommonAreaResponseDto>> GetCommonAreaById(int id)
		{
			try
			{
				var response = new BaseResponse<CommonAreaResponseDto>();
				var commonArea = await _unitOfWork.CommonArea.CommonAreaById(id);

				if (commonArea is not null)
				{
					response.IsSuccess = true;
					response.Data = _mapper.Map<CommonAreaResponseDto>(commonArea);
					response.Message = "Consulta exitosa";
				}
				else
				{
					response.IsSuccess = false;
					response.Message = "No se encontraron registros";
				}
				return response;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al obtener el area comun {ex.Message}");
			}
		}

		public async Task<BaseResponse<bool>> RegisterCommonArea(CommonAreaRequestDto area)
		{
			try
			{
				var response = new BaseResponse<bool>();
				var validationResult = await _validationRules.ValidateAsync(area);

				if (!validationResult.IsValid)
				{
					response.IsSuccess = false;
					response.Message = "Hay errores de validacion";
					response.Errors = validationResult.Errors;
					return response;
				}

				var commonArea = _mapper.Map<CommonArea>(area);
				response.Data = await _unitOfWork.CommonArea.RegisterCommonArea(commonArea);

				if (response.Data)
				{
					response.IsSuccess = true;
					response.Message = "Area comun registrada exitosamente";
				}
				else
				{
					response.IsSuccess = false;
					response.Message = "El area comun no se ha registrado";
				}
				return response;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al registrar el area comun {ex.Message}");
			}
		}

		public async Task<BaseResponse<bool>> UpdateCommonArea(CommonAreaRequestDto area, int id)
		{
			try
			{
				var response = new BaseResponse<bool>();
				var existCommonArea = await GetCommonAreaById(id);

                if (existCommonArea.Data is null)
                {
					response.IsSuccess = false;
					response.Message = "El area comun no ha sido encontrada";
                }

				var commonArea = _mapper.Map<CommonArea>(area);
				commonArea.Id = id;
				response.Data = await _unitOfWork.CommonArea.UpdateCommonArea(commonArea);

				if (response.Data)
				{
					response.IsSuccess = true;
					response.Message = "Area comun se ha actualizado exitosamente";
				}
				else
				{
					response.IsSuccess = false;
					response.Message = "El area comun no se ha actualizado";
				}
				return response;
			}
			catch (Exception ex)
			{
				throw new Exception($"Ha ocurrido un error al actualizar el area comun {ex.Message}");
			}
		}
	}
}
