using CoreAPI.Dtos;
using CoreAPI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreAPI.Profiles
{
    public class CommandsProfile :Profile
    {
        public CommandsProfile()
            
        {
            //source to target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
