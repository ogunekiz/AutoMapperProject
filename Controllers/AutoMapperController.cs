using AutoMapper;
using AutoMapperProject.Dtos;
using AutoMapperProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoMapperController : ControllerBase
    {
        private readonly IMapper _mapper;

        public AutoMapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(PersonDto personDto)
        {
           Person person = _mapper.Map<Person>(personDto);

            return Ok(person);
        }

    }
}
