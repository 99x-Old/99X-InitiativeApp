using System;

namespace InitiativeApp.API.Dtos
{
    public class MeetingsDto
    {
        public int MeetingId { get; set; }
		public string MeetingName { get; set; }
		public DateTime ScheduledTime { get; set; }
		public int InitiativeId { get; set; }
    }
}