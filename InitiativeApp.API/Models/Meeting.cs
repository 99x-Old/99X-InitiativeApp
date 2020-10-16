using System;
using System.ComponentModel.DataAnnotations;

namespace InitiativeApp.API.Models
{
    public class Meeting
    {
		[Key]
		public int MeetingId { get; set; }
		public string MeetingName { get; set; }
		public DateTime ScheduledTime { get; set; }
		public int InitiativeId { get; set; }
    }
}