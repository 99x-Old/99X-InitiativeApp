using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InitiativeApp.API.Models
{
	public class Initiative
	{
		[Key]
		public int InitiativeId { get; set; }
		public string InitiativeName { get; set; }
		public string Description { get; set; }
		public string InCharge { get; set; }
		public int IniiativeYear { get; set; }
		public ICollection<Meeting> Meetings { get; set; }
		public ICollection<ReviewCycle> ReviewCycles { get; set; }

	}
}