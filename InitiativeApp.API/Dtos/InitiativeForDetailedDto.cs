using System.Collections.Generic;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Dtos
{
    public class InitiativeForDetailedDto
    {
        public int InitiativeId { get; set; }
        public string InitiativeName { get; set; }
		public string Description { get; set; }
		public string InCharge { get; set; }
		public ICollection<Meeting> Meetings { get; set; }
		public ICollection<ReviewCycle>	ReviewCycles { get; set; }
    }
}