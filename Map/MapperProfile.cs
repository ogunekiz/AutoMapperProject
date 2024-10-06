using AutoMapper;
using AutoMapperProject.Dtos;
using AutoMapperProject.Entities;

namespace AutoMapperProject.Map
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
        }
    }
}
