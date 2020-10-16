using System.Collections.Generic;
using System.Threading.Tasks;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Data
{
    public interface IMeetingsRepository
    {
        Task<Meeting> AddMeeting(MeetingsDto meeting);
		Task<bool> DeleteMeeting(int id);
		Task<bool> SaveAll();
		Task<IEnumerable<Meeting>> GetMeetings();
		Task<Meeting> GetMeeting(int id);
    }
}