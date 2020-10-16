using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Data;
using InitiativeApp.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InitiativeApp.API.Controllers
{
	[Route("api/[controller]")]
	public class MeetingController : ControllerBase
	{
		private readonly IMeetingsRepository _repo;
		private readonly IMapper _mapper;

		public MeetingController(IMeetingsRepository repo, IMapper mapper)
		{
			_repo = repo;
			_mapper = mapper;
		}

		[HttpPost]
		public async Task<IActionResult> AddMeeting(MeetingsDto meetingDto)
		{
			var newMeeting = await _repo.AddMeeting(meetingDto);
			return Ok(newMeeting);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteMeeting(int id)
		{
			var deletedMeeting = await _repo.DeleteMeeting(id);
			return Ok(deletedMeeting);
		}

		[HttpGet]
		public async Task<IActionResult> GetMeetings()
		{
			var meetings = await _repo.GetMeetings();
			var meetingsToReturn = _mapper.Map<IEnumerable<MeetingsDto>>(meetings);
			return Ok(meetingsToReturn);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetMeeting(int id)
		{
			var meeting = await _repo.GetMeeting(id);
			var meetingToReturn = _mapper.Map<MeetingsDto>(meeting);
			return Ok(meetingToReturn);
		}

	}
}