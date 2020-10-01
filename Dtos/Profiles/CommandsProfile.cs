using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {   //source (Command) -> target (CommandReadDto)
            CreateMap<Command, CommandReadDto>();

            //target (CommandReadDto)  -> source (Command) 
            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}