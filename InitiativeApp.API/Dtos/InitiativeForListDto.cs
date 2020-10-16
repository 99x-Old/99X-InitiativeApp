using System.Collections.Generic;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Dtos
{
    public class InitiativeForListDto
    {
        public int InitiativeId { get; set; }
        public string InitiativeName { get; set; }
		public string Description { get; set; }
		public string InCharge { get; set; }
    }
}