using System.ComponentModel.DataAnnotations;

namespace InitiativeApp.API.Models
{
    public class ReviewCycle
    {
		[Key]
        public int ReviewCycleId { get; set; }
		public string ReviewCycleName { get; set; }
		public int InitiativeId { get; set; }
    }
}