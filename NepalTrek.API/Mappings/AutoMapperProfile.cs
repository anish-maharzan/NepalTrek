using AutoMapper;
using NepalTrek.API.Models.Domain;
using NepalTrek.API.Models.DTO;

namespace NepalTrek.API.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Region, RegionDtoV1>().ReverseMap();
            CreateMap<Region, RegionDtoV2>()
                .ForMember(x => x.FullName,
                                option => option.MapFrom(x => x.Name))
                .ReverseMap();

            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();

            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<UpdateWalkRequestDto, Walk>().ReverseMap();


            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
        }
    }
}
