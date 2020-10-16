using InitiativeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Initiative> Initiatives { get; set; }
		public DbSet<Meeting> Meetings { get; set; }
		public DbSet<Actions> Actions { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<ReviewCycle> ReviewCycles { get; set; }

	}
}