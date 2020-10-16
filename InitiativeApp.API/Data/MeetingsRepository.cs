using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class MeetingsRepository : IMeetingsRepository
	{
		private readonly DataContext _context;
		private readonly IMapper _mapper;
		public MeetingsRepository(DataContext context,IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Meeting> AddMeeting(MeetingsDto meetingDto)
		{
			var mapped = _mapper.Map<Meeting>(meetingDto);
			await _context.Meetings.AddAsync(mapped);
			await _context.SaveChangesAsync();
			return mapped;
		}

		public async Task<bool> DeleteMeeting(int id)
		{
			var deleteMeeting = await _context.Meetings.FirstOrDefaultAsync(m=>m.MeetingId == id);
			_context.Meetings.Remove(deleteMeeting);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<Meeting> GetMeeting(int id)
		{
			var meeting = await _context.Meetings.FirstOrDefaultAsync(m=>m.MeetingId == id);
			return meeting;
		}

		public async Task<IEnumerable<Meeting>> GetMeetings()
		{
			var meetings = await _context.Meetings.ToListAsync();
			return meetings;
		}

		public async Task<bool> SaveAll()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}