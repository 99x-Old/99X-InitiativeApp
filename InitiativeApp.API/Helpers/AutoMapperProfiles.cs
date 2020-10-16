using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Helpers
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<User, UserForListDto>();
			CreateMap<User, UserForDetailedDto>();
			CreateMap<Initiative, InitiativeForListDto>();
			CreateMap<Initiative, InitiativeForDetailedDto>();
			CreateMap<Actions, ActionsDto>();
			CreateMap<Comment, CommentsDto>();
			CreateMap<Meeting, MeetingsDto>();
			CreateMap<ReviewCycle, ReviewCycleDto>();
		}
	}
}