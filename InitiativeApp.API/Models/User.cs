using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InitiativeApp.API.Models
{
    public class User
    {
		[Key]
        public int Id { get; set; }
		public string Username { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public DateTime DateOfBirth { get; set; }
		public DateTime Created { get; set; }
		public DateTime LastActive { get; set; }
		public bool IsActive { get; set; }
	}
}