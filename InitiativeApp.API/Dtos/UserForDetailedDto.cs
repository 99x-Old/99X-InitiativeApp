using System;

namespace InitiativeApp.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
		public string Username { get; set; }
		public DateTime DateOfBirth { get; set; }
		public DateTime Created { get; set; }
		public DateTime LastActive { get; set; }
    }
}