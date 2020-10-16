using System;
using System.Collections.Generic;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Dtos
{
    public class ActionsDto
    {
        public int ActionId { get; set; }
		public string ActionName { get; set; }
		public DateTime ExpiredOn { get; set; }
		public int InitiativeId { get; set; }
		public int Id { get; set; }
		public ICollection<Comment> Comments { get; set; }
    }
}