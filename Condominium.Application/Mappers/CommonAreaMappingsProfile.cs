using AutoMapper;
using Condominium.Application.Dtos.Request;
using Condominium.Application.Dtos.Response;
using Condominium.Domain.Entities;

namespace Condominium.Application.Mappers
{
	public class CommonAreaMappingsProfile : Profile
	{
		public CommonAreaMappingsProfile()
		{
			CreateMap<CommonAreaRequestDto, CommonArea>().ReverseMap();
			CreateMap<CommonAreaResponseDto, CommonArea>().ReverseMap();
		}
	}
}
