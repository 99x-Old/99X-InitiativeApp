using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InitiativeApp.API.Models
{
	public class Actions
	{
		[Key]
		public int ActionId { get; set; }
		public string ActionName { get; set; }
		public DateTime ExpiredOn { get; set; }
		public int InitiativeId { get; set; }
		public int Id { get; set; }
		public ICollection<Comment> Comments { get; set; }
	}
}