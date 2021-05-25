using AutoMapper;
using Dtos;
using Models;

namespace Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command,CommandReadDto>();
        }
    }
}