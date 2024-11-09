using AutoMapper;
using Polls.Core.DTOs;
using Polls.Core.DTOs.PollOptionDtos;
using Polls.Core.DTOs.VoteDto;
using Polls.Core.Models;

namespace Polls.Business.AutoMapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Poll, PollDto>();
        CreateMap<PollDto, Poll >();
        CreateMap<PollInsertDto, Poll>();
        CreateMap<PollOptionDto, PollOption>();
        CreateMap<PollOption, PollOptionDto>();
        CreateMap<PollOptionInsertDto, PollOption>();
        CreateMap<VoteInsertDto, Vote>();
        CreateMap<Vote, VoteInsertDto>();
        CreateMap<VoteDto, Vote>();
        CreateMap<Vote, VoteDto>();
    }
    
}