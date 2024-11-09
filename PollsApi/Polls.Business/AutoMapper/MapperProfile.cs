using AutoMapper;
using Polls.Core.DTOs;
using Polls.Core.Models;

namespace Polls.Business.AutoMapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Poll, PollDto>();
        CreateMap<PollDto, Poll >();
    }
    
}